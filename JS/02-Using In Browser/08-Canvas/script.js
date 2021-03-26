let img = new Image();
img.src = './cface.png';

function clockPainting() {
  let now = new Date();
  let sec = now.getSeconds();
  let min = now.getMinutes();
  let hr = now.getHours();

  let ctx = document.getElementById("clock").getContext("2d");

  ctx.clearRect(0, 0, 150, 150);

  ctx.drawImage(img, 0, 0, 150, 150);
  
  ctx.restore(); // достаем последний сохраненный контекст из стэка
  ctx.save();

  ctx.translate(75, 75);
  ctx.scale(0.4, 0.4);
  ctx.rotate(-Math.PI / 2);

  ctx.strokeStyle = "black";
  ctx.fillStyle = "black";
  ctx.lineWidth = 8;
  ctx.lineCap = "round";

  ctx.save();
  ctx.restore(); // достаем последний сохраненный контекст из стэка

  ctx.save();
  // рисуем часовую стрелку, вращая холст
  ctx.rotate((Math.PI / 6) * hr +
      (Math.PI / 360) * min +
      (Math.PI / 21600) * sec);
  ctx.lineWidth = 14;

  ctx.beginPath();
  ctx.moveTo(-20, 0);

  // линия почти до часовых меток
  ctx.lineTo(80, 0);
  ctx.stroke();
  ctx.restore();

  ctx.save();

  // минутная стрелка
  ctx.rotate((Math.PI / 30 * min) +
      (Math.PI / 1800) * sec);
  ctx.lineWidth = 10;

  ctx.beginPath();
  ctx.moveTo(-28, 0);
  ctx.lineTo(112, 0);
  ctx.stroke();
  ctx.restore();

  ctx.save();

  // секундная стрелка
  ctx.rotate(sec * Math.PI / 30);
  ctx.strokeStyle = "#D40000"; // цвет контура
  ctx.fillStyle = "#D40000";
  ctx.lineWidth = 6;

  ctx.beginPath();
  ctx.moveTo(-30, 0);
  ctx.lineTo(83, 0);
  ctx.stroke();
  ctx.restore();

  ctx.restore();
}

img.addEventListener("load", function() {
  window.onload = function() {
    setInterval(clockPainting, 1000); // функция, перерисовывающая часы
    //через равные промежутки времени
  }
}, false);