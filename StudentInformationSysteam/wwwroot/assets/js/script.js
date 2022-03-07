/*===== EXPANDER MENU  =====*/
const showMenu = (toggleId, navbarId, bodyId) => {
    const toggle = document.getElementById(toggleId),
        navbar = document.getElementById(navbarId),
        bodypadding = document.getElementById(bodyId)

    if (toggle && navbar) {
        toggle.addEventListener('click', () => {
            navbar
                .classList
                .toggle('expander')

            bodypadding
                .classList
                .toggle('body-pd')
        })
    }
}
showMenu('nav-toggle', 'navbar', 'body-pd')

/*===== LINK ACTIVE  =====*/
const linkColor = document.querySelectorAll('.nav__link')
function colorLink() {
    linkColor.forEach(l => l.classList.remove('active'))
    this
        .classList
        .add('active')
}
linkColor.forEach(l => l.addEventListener('click', colorLink))

/*===== COLLAPSE MENU  =====*/
const linkCollapse = document.getElementsByClassName('collapse__link')
var i

for (i = 0; i < linkCollapse.length; i++) {
    linkCollapse[i].addEventListener('click', function () {
        const collapseMenu = this
            .nextElementSibling
            collapseMenu
            .classList
            .toggle('showCollapse')

        const rotate = collapseMenu
            .previousElementSibling
            rotate
            .classList
            .toggle('rotate')
    })
}

let asideButton = document.getElementById('shw');
let aside = document.getElementById('Aside');
//let body=document.getElementById('Table');

let closeBtn = document.getElementById('CloseBtn');

asideButton.addEventListener("click", function () {
    aside
        .classList
        .remove('close');
    aside
        .classList
        .add('show');
    //   body.classList.add('blur');

    closeBtn
        .classList
        .add('show-close-btn')
});

closeBtn.addEventListener("click", function () {

    aside
        .classList
        .remove('show');
    aside
        .classList
        .add('close');
    closeBtn
        .classList
        .remove('show-close-btn')
    closeBtn
        .classList
        .add('close-aside')
});
$(document).ready(function () {

 let a= $('#Aside').width()

  $(window).resize(function(){

    // if(a<256){
    //     $('#CloseBtn')
    //     .removeClass('show-close-btn')
    // }
    if (window.innerWidth > 993) {
  
        $('#Aside').removeClass('close');
      
        $('#CloseBtn')
        .removeClass('show-close-btn')
    }
    else{
        $('#CloseBtn')
        .addClass('show-close-btn')
    }
    // if()
    // {
    //     $('#CloseBtn')
    //     .removeClass('show-close-btn')
    // }
  })



});

var element = document.getElementsByClassName("sidebar-menu")[0];
element.addEventListener("click", myFunction);
function myFunction(e) {
		var elems = document.querySelector(".active");
    if(elems !=null) {
      elems.classList.remove("active");
    }
    e.target.className = "active";
	}
////////////
