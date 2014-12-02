//slide animation part
$(function () {
    //current page
    var pageindex = 0;
    //get the count of the slide photo
    var pagelen = $("#slide ul.slidephoto li").length;
    //get the width of the slide photo
    var width = $("#slide ul.slidephoto li img").width();
    var slideTimer;

    //when your mouse is on the indicator ,move!
    $("#slide ul.slideindicator li").click(function () {
        //get the  click indicator li index and set it to pageindex
        pageindex = $("#slide ul.slideindicator li").index(this);
        //showImg
        ShowImg(pageindex);
    }).eq(0).click();

    //set the timer
    $("#slide").hover(function () {
        //if mouse is over the slide photo,stop the timer
        clearInterval(slideTimer);
    }, function () {
        slideTimer = setInterval(function () {
            ShowImg(pageindex);
            pageindex++;
            //clear to understand
            if (pageindex == pagelen) {
                pageindex = 0;
            }
        }, 4000);
    }).trigger("mouseleave");

    function ShowImg(pageindex) {
        //move to left a width
        $("#slide ul.slidephoto").stop().animate({ left: -width * pageindex }, "slow");
        //indicator the pageindex
        $("#slide ul.slideindicator li").removeClass("selected").eq(pageindex).addClass("selected");
    }

});