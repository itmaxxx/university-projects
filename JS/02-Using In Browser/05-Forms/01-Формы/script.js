const SEAT_SIZE = 42;

function handleSeatClick(e, x, y) {
  console.log(e, x, y);

  console.log(e.target.src);

  if (e.target.src.indexOf('img/seat.png') !== -1) {
    e.target.src = 'img/seat-success.png';
  } else {
    e.target.src = 'img/seat.png';
  }
}

function generateSeats(rows, cols, spaces) {
  seats.style.width = `${SEAT_SIZE * cols}px`;

  for (let y = 0; y < rows; y++) {
    spaces.forEach(space => {
      if (y === space) {
        let spaceEl = document.createElement('div');
        spaceEl.style.width = `${SEAT_SIZE * cols}px`;
        spaceEl.style.height = `${SEAT_SIZE / 2}px`;
  
        seats.appendChild(spaceEl);
      }
    })

    for (let x = 0; x < cols; x++) {
      let seat = document.createElement('div');
      seat.className = 'seat';
      seat.addEventListener('click', (e) => handleSeatClick(e, x, y));
      let img = document.createElement('img');
      img.src = 'img/seat.png';
      seat.appendChild(img);
  
      seats.appendChild(seat);
    }
  }
}

generateSeats(4, 10, [1, 3]);