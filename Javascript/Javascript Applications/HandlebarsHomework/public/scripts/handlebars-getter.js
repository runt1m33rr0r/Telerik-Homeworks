var handlebarsGetter = (function() {
    let cachedHandlebars = {};

    function getHandlebars(name) {
        if (!name) {
            throw Error('Name of the handlebars must not be empty');
        }

        return new Promise((resolve, reject) => {
            if (cachedHandlebars[name]) {
                resolve(cachedHandlebars[name]);
            } else {
                $.ajax({
                        type: 'GET',
                        url: '/handlebars/' + name + '.handlebars'
                    }).done((data) => {
                        let template = Handlebars.compile(data);
                        cachedHandlebars[name] = template;
                        resolve(template);
                    })
                    .fail(reject);
            }
        });
    }

    return {
        get: getHandlebars
    };
}());