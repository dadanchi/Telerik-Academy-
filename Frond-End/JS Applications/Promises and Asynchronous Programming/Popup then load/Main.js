let promise = new Promise((resolve, reject) => {
    let button = document.getElementById('btn');

    button.addEventListener("click", () => {
        createPopUp();

        setTimeout(() => resolve(), 2000);

        function createPopUp() {
            let div = document.createElement('div');
            div.innerText = "HERE COMES THE PUSSY";
            div.style.backgroundColor = "pink";
            div.style.width = "1300px";
            div.style.height = "600px";
            div.style.color = "yellow";
            div.style.textAlign = "center";
            div.style.fontSize = "90px";

            document.body.appendChild(div);
        }
    })

});

promise.then(value => {
    window.location.replace("http://i2.cdn.cnn.com/cnnnext/dam/assets/150324154019-09-internet-cats-restricted-super-169.jpg");
});