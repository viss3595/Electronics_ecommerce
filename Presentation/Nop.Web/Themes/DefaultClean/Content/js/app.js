function moremenuleft() {
    if ($(document).width() <= 1199) {
        var max_elem = 6
    } else if ($(document).width() >= 1200 && $(document).width() <= 1459) {
        var max_elem = 7
    } else if ($(document).width() >= 1460 && $(document).width() <= 1659) {
        var max_elem = 9
    } else {
        var max_elem = 13
    }
    var more_info = "more";
    var less_info = "less";
    var menu = $('#tt-megamenu .tt_menus_ul > li');
    if (menu.length > max_elem) {
        $('#tt-megamenu ul.tt_menus_ul').append('<li class="tt_menu_item left_more_menu"><div class="level-top left mega-menu-link"><span class="categories">' + more_info + '<i class="mdi mdi-plus"></i></span></div></li>')
    }
    $('#tt-megamenu ul.tt_menus_ul .left_more_menu').click(function () {
        if ($(this).hasClass('active')) {
            menu.each(function (j) {
                if (j >= max_elem) {
                    $(this).slideUp(200)
                }
            });
            $(this).removeClass('active');
            $('.left_more_menu').html('<span class="categories">' + more_info + '<i class="mdi mdi-plus"></i></span>')
        } else {
            menu.each(function (j) {
                if (j >= max_elem) {
                    $(this).slideDown(200)
                }
            });
            $(this).addClass('active');
            $('.left_more_menu').html('<span class="categories">' + less_info + ' <i class="mdi mdi-minus"></i></span>')
        }
    });
    menu.each(function (j) {
        if (j >= max_elem) {
            $(this).css('display', 'none')
        }
    })
}
$(document).ready(function () {
    moremenuleft()
});


