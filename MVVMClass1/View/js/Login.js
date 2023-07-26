window.addEventListener("resize", function () {
    FormTop();
})

window.addEventListener("focus", function () {
    FormTop();
})

window.addEventListener("load", function () {
    FormTop();
})

function FormTop() {

    var altoventana = window.innerHeight;
    var elementos = document.getElementById("loginbox");
    elementos.style.top = altoventana / 8 + "px";
}