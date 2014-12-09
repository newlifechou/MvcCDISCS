$(function () {
    var $serviceitem = $("#rightpartcontent .serviceitem");
    $serviceitem.hover(function () {
        $(this).addClass("mo");
    }, function () {
        $(this).removeClass("mo");
    });
});