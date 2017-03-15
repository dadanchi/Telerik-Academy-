function clickButton(event, parameters) {
    let myWindow = window;
    let browser = myWindow.navigator.appCodeName;
    let isMozilla = browser === "Mozilla";

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}