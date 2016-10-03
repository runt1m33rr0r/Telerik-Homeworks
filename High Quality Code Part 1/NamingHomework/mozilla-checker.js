function checkIfUsingMozilla() {
    var currentWindow = window;
    var currentBrowser  = currentWindow.navigator.appCodeName;
    var isUsingMozilla = currentBrowser === 'Mozilla';

    if (isUsingMozilla) {
        alert('Yes');
    } else {
        alert('No');
    }
}