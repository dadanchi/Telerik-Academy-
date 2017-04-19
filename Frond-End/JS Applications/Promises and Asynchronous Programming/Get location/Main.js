let root = document.getElementById("root");
let button = document.getElementById("btn");

button.addEventListener("click", () => {
    let promise = new Promise((resolve, reject) => {
        if (!navigator.geolocation) {
            root.innerHTML = "Geolocation is not supported by this browser.";
            return;
        }

        navigator.geolocation.getCurrentPosition(resolve);
    });

    promise.then(position => {
        let img = document.createElement("img");
        img.src = `https://maps.googleapis.com/maps/api/staticmap?center=
        ${position.coords.latitude},${position.coords.longitude}&zoom=12&size=400x400&key=`;

        root.appendChild(img);
    });
});