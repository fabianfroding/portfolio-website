var slideIndex = 1;
var slideTimer;

function plusDivs(n) {
    showDivs(slideIndex += n);
    if (slideTimer) {
        clearTimeout(slideTimer);
        slideTimer = null;
    }
    slideTimer = setTimeout(autoUpdate, 5000);
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
    else if (n <= 0) {
        slideIndex = x.length;
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

function autoUpdate() {
    plusDivs(+1);
    
}

window.onload = function () {
    var dots = document.getElementsByClassName("dot");
    if (dots.length > 0) {
        dots[0].className = dots[0].className.replace("dot", "dot active");
        for (var i = 0; i < dots.length; i++) {
            dots[i].addEventListener('click', function (arg) {
                return function () {
                    currentSlide(arg);
                }
            }(i + 1), false);
        }
        slideTimer = setTimeout(autoUpdate, 5000);
    }
}
