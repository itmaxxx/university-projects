function zoom(imgNum) {
  let win = window.open('', `P${imgNum}.jpg`);
  win.document.write(`<html><head><title>Viewing image P${imgNum}.jpg</title><style>* { padding: 0; margin: 0; }</style></head><body style="overflow: hidden;"><div style="width: 100vw; height: 100vh; background-image: url('/img/P${imgNum}.JPG'); background-size: cover; background-position: center;"></div></body></html>`);
}

function handleMouseOver(imgNum) {
  image_preview.src = `/img/P${imgNum}.jpg`;
  
  let width = image_preview.width, height = image_preview.height;
  

  document.title = `${width}x${height}px P${imgNum}.jpg`;
}

function handleMouseOut() {
  document.title = 'Gallery';
}

function hangHandlers() {
  let images = document.getElementsByClassName('gallery__image');

  Array.from(images).forEach((img, index) => {
    img.addEventListener('click', () => zoom(index));
    img.addEventListener('mouseover', () => handleMouseOver(index));
    img.addEventListener('mouseout', () => handleMouseOut());
  })
}

hangHandlers();