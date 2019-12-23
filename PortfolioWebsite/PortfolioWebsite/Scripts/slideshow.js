var slideIndex = 0;

function plusDivs() {
    showDivs(slideIndex++);
}

function currentSlide(n) {
    showDivs(slideIndex = n);
}

function showDivs(n) {
    var i;
    var x = document.getElementsByClassName("slides");
    var dots = document.getElementsByClassName("dot");
    if (n > x.length) {
        slideIndex = 0
    }
    for (i = 0; i <= x.length; i++) {
        x[i].style.display = "none";
    }
    for (i = 0; i <= dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    x[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
    setTimeout(function () {
        plusDivs(1)
    }, 2000);
}
