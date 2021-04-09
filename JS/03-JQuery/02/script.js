$(function() {
  $("#resizable1").resizable({ minWidth: 300, maxWidth: 300 });
  $('#resizable1').on('resize', (e) => { 
    console.log($('#resizable1').height(), $('#resizable2').height(), $('body').height());

    $('#resizable2').height($('body').height() - $('#resizable1').height());
  });
  $("#resizable2").resizable({ minWidth: 300, maxWidth: 300 });

  $('.side-menu').toggle('slide', 500);
});