// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var toggler = document.getElementsByClassName("caret");
var i;

for (i = 0; i < toggler.length; i++) {
    toggler[i].addEventListener("click", function () {
        let classList = this.parentElement.querySelector(".nested").classList
        if (classList) {
            this.parentElement.querySelector(".nested").classList.toggle("nested__active");
        }
    });
}