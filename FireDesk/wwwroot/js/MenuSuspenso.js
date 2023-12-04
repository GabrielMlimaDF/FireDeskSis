var btn = document.getElementById("gestao-mod");
var div = document.getElementById("div-menu-sus");
console.log(div)

btn.addEventListener("click", function () {
    var div = document.getElementById("div-menu-sus");

    if (div.style.display === "none") {
        div.style.display = "flex";
    }
    else {
        div.style.display = "none";
    }

});