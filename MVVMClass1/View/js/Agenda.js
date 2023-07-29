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

function hideDelete() {

    var DeletePanel = document.getElementById("DeletePanel");
    DeletePanel.style.display = "none";


}

function showDelete() {

    var DeletePanel = document.getElementById("DeletePanel");
    DeletePanel.style.display = "block";

}

function HideEdit() {

    var editPanel = document.getElementById("editPanel");
    editPanel.style.display = "none";

}

function ShowEdit() {

    var editPanel = document.getElementById("editPanel");
    editPanel.style.display = "block";

}