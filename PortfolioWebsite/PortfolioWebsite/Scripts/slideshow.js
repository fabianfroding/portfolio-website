var slideIndex = 1;

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

function autoUpdate() {
    plusDivs(+1);
    setTimeout(autoUpdate, 5000);
}

window.onload = function () {
    var dots = document.getElementsByClassName("dot");
    dots[0].className = dots[0].className.replace("dot", "dot active");
    for (var i = 0; i < dots.length; i++) {
        dots[i].addEventListener('click', function (arg) {
            return function ()
            {
                currentSlide(arg);
            }
        }(i+1), false);
    }
    setTimeout(autoUpdate, 5000);
}
