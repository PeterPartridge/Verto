$(document).foundation();

var elem = new Foundation.Orbit($("#headerCarosel"));
var caratablet = new Foundation.Orbit($("#headerCaroselTablet"));
var caradesktop = new Foundation.Orbit($("#headerCaroselDesktop"));

var elem2 = new Foundation.Orbit($("#repeaterList", {"data-auto-play":"true"}));

$('.catagoriesSlider').slick({
    infinite: true,
    loop: false,
    arrows: true,
    mobileFirst:true,
    responsive: [
        {
            breakpoint: 0,
            settings: {

                slidesToShow: 2,
                slidesToScroll: 2,
                arrows: true
            }
        },
        {
            breakpoint: 700,
            settings: {

                slidesToShow: 2,
                slidesToScroll: 2,
                arrows: true
            }
        },
 
            
        {
            breakpoint: 1080,
            settings: {

                slidesToShow: 4,
                slidesToScroll: 4,
                arrows: true
            }
        }
    ]
});
