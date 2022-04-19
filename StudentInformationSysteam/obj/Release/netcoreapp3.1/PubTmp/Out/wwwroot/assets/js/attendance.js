$('.onoffbtn').on('click', function(){
    if($(this).children().is(':checked')){
      $(this).addClass('active');
    }
    else{
      $(this).removeClass('active')
    }
  });