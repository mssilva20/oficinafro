$(function () {
 //abre e fecha menu
 $('.nav-toggle, .nav-close').click(function(e){
  e.preventDefault();
  console.log('ok');
  $('.nav').toggleClass('active');
 });

});

