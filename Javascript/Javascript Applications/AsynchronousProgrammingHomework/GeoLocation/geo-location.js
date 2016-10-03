(function () {
    function getLocation() {
        let locationPromise = new Promise((resolve, reject) => {
            navigator.geolocation.getCurrentPosition((position) => {
                resolve(position);
            });
        });

        return locationPromise;
    }

    function showLocationImage(position) {
		let longitude = position.coords.longitude;
        let latitude = position.coords.latitude;
        let mapImage = new Image();

        mapImage.src = "https://maps.googleapis.com/maps/api/staticmap?center=" + latitude + "," + longitude + "&zoom=15&size=500x500&sensor=false";
        document.body.appendChild(mapImage);
    }

    getLocation()
        .then((success) => {
            showLocationImage(success);
        }, (error) => {
            console.error(error);
        });
}());