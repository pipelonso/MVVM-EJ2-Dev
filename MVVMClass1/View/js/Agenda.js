const btnShowAddTaks = document.getElementById("btnShowAddTaks");

btnShowAddTaks.addEventListener("click", function () {

    var addPanel = document.getElementById("addPanel");
    addPanel.style.display = "block";
    var wexpand = document.getElementById("wexpand");
    //wexpand.classList.add("w-100");

})

btnShowAddTaks.addEventListener("mouseenter", function () {

    btnShowAddTaks.style.cursor = "pointer";

})

this.addEventListener("load", function () {

    var addPanel = document.getElementById("addPanel");
    addPanel.style.display = "none";

})


function hideContent() {
    console.log("a");
    var contenido = document.getElementById("contenido");
    contenido.style.display = "none";

}