window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    if (document.body.scrollTop > 5 || document.documentElement.scrollTop > 5) {

        var elements = document.getElementsByClassName("main-header");
        var nav = document.getElementsByClassName("nav");
        var siteLogoImage = document.getElementsByClassName("site-logo-image");
        elements[0].style.height = "70px";
        nav[0].style.paddingRight = "3em";
        siteLogoImage[0].style.width = "70px";
        siteLogoImage[0].style.height = "30px";

        var navItems = document.getElementsByClassName("nav-item");
        for (var i = 0; i < navItems.length; i++) {
            navItems[i].style.fontSize = "0.875em";
        }

    } else {

        var elements = document.getElementsByClassName("main-header");
        var nav = document.getElementsByClassName("nav");
        var siteLogoImage = document.getElementsByClassName("site-logo-image");
        elements[0].style.height = "80px";
        nav[0].style.paddingRight = "1em";
        siteLogoImage[0].style.width = "85px";
        siteLogoImage[0].style.height = "41px";

        var navItems = document.getElementsByClassName("nav-item");
        for (var i = 0; i < navItems.length; i++) {
            navItems[i].style.fontSize = "1.125em";
        }
    }
}