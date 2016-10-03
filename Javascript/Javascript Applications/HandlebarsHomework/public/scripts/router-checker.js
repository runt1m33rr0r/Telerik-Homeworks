(function() {
    let router = new Navigo(null, false);

    function reloadThreads() {
        return new Promise((resolve, reject) => {
            handlebarsGetter.get('threads')
                .then((template) => {
                    data.threads.get()
                        .then((data) => {
                            let html = template(data);
                            $('#content').html(html);
                            resolve();
                        });
                });
        });
    }

    function reloadGallery() {
        return new Promise((resolve, reject) => {
			handlebarsGetter.get('gallery')
            .then((template) => {
                data.gallery.get()
                    .then((data) => {
                        let html = template(data.data);
                        $('#content').html(html);
						resolve();
                    })
                    .catch(console.log);
            });
		})
    }

    function showMessage(id) {
        return new Promise((resolve, reject) => {
            handlebarsGetter.get('message')
                .then((template) => {
                    data.threads.getById(id)
                        .then((data) => {
                            let html = template(data.result);
                            $('#content').append(html);
                            resolve();
                        })
                        .catch((err) => showMsg(err, 'Error', 'alert-danger'));
                });
        });
    }

    router.on({
        '/threads/:id': (args) => {
            reloadThreads()
                .then(() => { showMessage(args.id).then(() => {}) });
        },
        '/threads': () => {
            reloadThreads()
                .then(() => {});
        },
        '/gallery': () => {
            reloadGallery()
				.then(() => {});
        },
        '*': () => {
            $('#content').html('');
        }
    }).resolve();
})();