window.addEventListener("scroll", function () {
    var scrollPosition = document.documentElement.scrollTop ;
    var windowHeight = document.documentElement.scrollHeight - document.documentElement.clientHeight;
    var progress = (scrollPosition / windowHeight) * 100;

    var progressbar = this.document.getElementById("progressbar");

    progressbar.style.width = progress + "%"

    

})