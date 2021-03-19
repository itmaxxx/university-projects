function init() {
  let ctx = document.querySelector('#clocks').getContext("2d");
  
  if (ctx) {
    var img = new Image();
    img.src = './cface.png';
    img.style.height = img.style.width = '600px';

    img.addEventListener("load", function() {
      ctx.drawImage(img, 0, 0);
    }, false);
  }
}

window.onload = init;