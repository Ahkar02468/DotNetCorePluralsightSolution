console.log("Hello World");

var form = document.getElementById("form");
form.hidden = true;

var button = document.getElementById("buybutton");
button.addEventListener("click", function () {
    alert("Buying Item")
});

var productinfo = document.getElementsByClassName("properties");
var ListItems = productinfo.item[0].children;
