$(document).ready(function () { 
console.log("Hello World");

var form = $("#form");
form.hide();

var button = $("#buybutton");
button.on("click", function () {
    alert("Buying Item")
});

var productinfo = $(".properties li");
productinfo.on("click", function () {
    console.log("You clicked this " + $(this).text());
});
    var $loginToggle = $("#LoginToggle");
    var $popupForm = $(".popup-form");
    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(500); 
    });

});
