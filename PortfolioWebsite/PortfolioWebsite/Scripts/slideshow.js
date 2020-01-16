var slideIndex = 1;
var dotsCounter = 0;

function plusDivs(n) {
    showDivs(slideIndex += n);
}

function currentSlide(n) {
    showDivs(slideIndex = n);
}

function showDivs(n) {
    var x = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
    if (n > x.length) {
        slideIndex = 1
    }
    for (var i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
    for (var i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    x[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
}

function createDot(n) {
    console.log("Hey");
    var dots = document.getElementsByClassName("dot");
    for (var i = 0; i < dots.length; i++) {
        var newSpan = document.createElement('span');
    }
}