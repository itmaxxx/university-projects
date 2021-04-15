$(function() {
  $("#resizable1").resizable({ minWidth: 300, maxWidth: 300 });
  $('#resizable1').on('resize', (e) => { 
    console.log($('#resizable1').height(), $('#resizable2').height(), $('body').height());

    $('#resizable2').height($('body').height() - $('#resizable1').height());
  });
  $('#toggler1').on('click', () => { 
    $('.side-menu__resizable').toggle('slide', 500); 

    $('.toggle-icon-right').toggleClass('toggle-icon-left');
  });

  $("#resizable3").resizable({ minWidth: 300, maxWidth: 300 });
  $('#resizable3').on('resize', (e) => { 
    console.log($('#resizable3').height(), $('#resizable4').height(), $('body').height());

    if ($('#resizable4').height() <= 200 && ($('body').height() - $('#resizable3').height()) < 200) {
      $('#resizable3').height($('body').height() - 200)

      return $('#resizable4').height(200);
    }

    $('#resizable4').height($('body').height() - $('#resizable3').height());
  });

  $('.ui-resizable-s').html('<img src="equals.png"/>');
});