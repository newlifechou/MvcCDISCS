$(function () {
    //when mouse is over the category list ,change the background the li mark
    //$("#leftarea ul.categorylist li").mouseover(function () {
    //    $(this).addClass("mo");
    //}).mouseout(function () {
    //    $(this).removeClass("mo");
    //});
    $("#leftarea ul.categorylist li").hover(
        function () {
            $(this).addClass("mo");
        },
        function () {
            $(this).removeClass("mo");
        }
    );

    //same height of the leftarea and rightarea in the middle part
    var h1 = $("div#leftarea ul.categorylist").height();
    var h2 = $("div#about").height();
    var h3;
    if (h1 > h2) {
        h3 = h1 - 6;
    }
    else {
        h3 = h2;
    }
    $("div#about").height(h3);


    //mo on slide photo demo
    $("#slide ul.slidephoto li p").hover(function () {
        $(this).addClass("mo");
    }, function () {
        $(this).removeClass("mo");
    });


    //notice show
    var noticeTimer;
    var noticeindex = 0;
    var $noticeli = $("#notice div.noticecontent ul li");
    var $noticeul = $("#notice div.noticecontent ul");
    var noticepage =$noticeli.length;
    var noticeheight = $noticeli.height();

    $("#notice div.noticecontent").hover(function () {
        clearInterval(noticeTimer);
    }, function () {
        noticeTimer = setInterval(function () {
            ShowNotice(noticeindex);
            noticeindex++;

            if (noticeindex == noticepage) {
                noticeindex = 0;
            }
        }, 6000);
    }).trigger("mouseleave");

    function ShowNotice(noticeindex) {
        $noticeul.stop().animate({ top: -noticeheight * noticeindex }, 1000);
    }
});