$(function () {
    //when click the menu nav ,change the style
    //$("#mainnav li a").click(function () {
    //    $(this).addClass("selected");
    //    $(this).parent().siblings().children("a").removeClass("selected");
    //});


    //open friendlink
    $("#btnFriendlinkGo").click(function () {
        var flstr = $("#FriendLinkList").val();
        window.open(flstr);
    });
});