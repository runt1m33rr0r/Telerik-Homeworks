(function () {
    let popup = document.getElementById('popup');
	popup.style.display = 'none';

    function timeout() {
        let timeoutPromise = new Promise((resolve, reject) => {
			popup.style.display = 'block';
			
            return setTimeout(() => {
                resolve({});
            }, 2000);
        });

        return timeoutPromise;
    }

    let button = document.getElementsByTagName('button')[0];

    button.addEventListener('click', event => {
        timeout().then((success) => {
                window.location = "https://www.google.com/";
            });
    });
}());