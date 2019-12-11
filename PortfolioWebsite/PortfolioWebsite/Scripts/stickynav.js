var mh = $(".main-header");

$(window).scroll(function () {
    if ($(this).scrollTop() > 250) {
        mh.addClass("nav-scrolled");
    }
    else {
        mh.removeClass("nav-scrolled");
    }
});