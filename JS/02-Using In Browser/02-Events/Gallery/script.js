const slidesCount = document.getElementsByClassName('slide__bg').length;
let currentSlide = 0;

function handlePreviewClick(num) {
  currentSlide = num;

  switchToImage();
}

function handleForwardClick() {
  currentSlide += 1;

  if (currentSlide >= slidesCount) {
    currentSlide = 0;
  }

  console.log(currentSlide);

  switchToImage();
}

function handleBackwardClick() {
  currentSlide -= 1;

  if (currentSlide < 0) {
    currentSlide = slidesCount - 1;
  }

  console.log(currentSlide);

  switchToImage();
}

function switchToImage() {
  let gallery = document.getElementsByClassName('slide__bg-wrap');

  gallery[0].style.transform = `translateX(-${currentSlide * 100}vw)`;
}

function hangHandlers() {
  let allItems = document.getElementsByClassName('item__preview');

  Array.from(allItems).forEach((item, index) => {
    item.addEventListener('click', () => handlePreviewClick(index));
  });

  document.getElementsByClassName('control__left')[0].addEventListener('click', handleBackwardClick);
  document.getElementsByClassName('control__right')[0].addEventListener('click', handleForwardClick);
}

hangHandlers();