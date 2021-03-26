const SIZE = 400;

let img = new Image();
img.src = './cface.png';

function paintClock() {
  let now = new Date();
  let sec = now.getSeconds();
  let min = now.getMinutes();
  let hr = now.getHours();

  let ctx = document.getElementById("clock").getContext("2d");

  ctx.restore();

  ctx.clearRect(0, 0, SIZE, SIZE);

  // Рисуем часы
  ctx.drawImage(img, 0, 0, SIZE, SIZE);
  ctx.save();

  ctx.translate(SIZE / 2, SIZE / 2);
  ctx.rotate(-Math.PI / 2);
  
  // Часовая стрелка
  ctx.strokeStyle = "black";
  ctx.fillStyle = "black";
  ctx.lineWidth = 8;

  ctx.save();

  ctx.rotate((Math.PI / 6) * hr +
      (Math.PI / 360) * min +
      (Math.PI / (3600 * 6)) * sec);
  ctx.lineWidth = 10;

  ctx.beginPath();
  ctx.moveTo(-10, 0);

  ctx.lineTo(SIZE * 0.15, 0);
  ctx.stroke();
  ctx.restore();

  ctx.save();

  // Минутная стрелка
  ctx.rotate((Math.PI / 30 * min) +
      (Math.PI / 1800) * sec);
  ctx.lineWidth = 6;

  ctx.beginPath();
  ctx.moveTo(-20, 0);
  ctx.lineTo(SIZE * 0.25, 0);
  ctx.stroke();
  ctx.restore();

  ctx.save();

  // Секундная стрелка
  ctx.rotate(sec * Math.PI / 30);
  ctx.strokeStyle = "red";
  ctx.lineWidth = 2;

  ctx.beginPath();
  ctx.moveTo(-30, 0);
  ctx.lineTo(SIZE * 0.3, 0);
  ctx.stroke();
  ctx.restore();

}

img.addEventListener("load", function() {
  window.onload = function() {
    setInterval(paintClock, 1000);
  }
}, false);