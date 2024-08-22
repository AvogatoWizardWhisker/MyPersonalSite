// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const themeName = 'dark-theme';
const itemDivs = document.querySelectorAll('.dark-theme');
const themeSwitcher = document.getElementById('theme-switcher');
const darkTheme = localStorage.getItem(themeName);

if(darkTheme === null){
    localStorage.setItem(themeName,"active");
} else if(darkTheme === "active"){
    addTheme();
} else {
    removeTheme();
}

themeSwitcher.addEventListener('click',function (){
    let currentTheme = localStorage.getItem(themeName);
    if(currentTheme === "inactive"){
        localStorage.setItem(themeName,"active");
        addTheme();
    } else if (currentTheme === "active"){
        localStorage.setItem(themeName,"inactive");
        removeTheme();
    }
})

function removeTheme(){
    itemDivs.forEach(itemDiv => {
        itemDiv.classList.remove(themeName);
    });
}

function addTheme(){
    itemDivs.forEach(itemDiv => {
        itemDiv.classList.add(themeName);
    });
}
