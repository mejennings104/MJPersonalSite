/*!
* Start Bootstrap - Full Width Pics v5.0.5 (https://startbootstrap.com/template/full-width-pics)
* Copyright 2013-2022 Start Bootstrap
* Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-full-width-pics/blob/master/LICENSE)
*/

$('section#cursor-move-bg').mousemove(function(a){
    var mouseX=(a.pageX*-1/15);
    var mouseY=(a.pageY*-1/15);
    $(this).css('background-position',mouseX+'px '+mouseY+'px')
})

const list = document.querySelectorAll('.list');
function activeLink(){
    list.forEach((item) =>
    item.classList.remove('active'));
    this.classList.add('active');
}
list.forEach ((item) => 
item.addEventListener('click', activeLink));

