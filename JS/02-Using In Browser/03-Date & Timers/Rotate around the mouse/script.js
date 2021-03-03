let rotatableObject;

function handleMouseMove(e) {
  rotatableObject.style.top = e.clientY - 20 + 'px';
  rotatableObject.style.left = e.clientX - 20 + 'px';
}

function hangHandlers() {
  rotatableObject = document.getElementById('element');

  document.getElementsByClassName('app')[0].addEventListener('mousemove', handleMouseMove);
}

hangHandlers();