const SEAT_SIZE = 42;

const directions = [
  'Odesa - Kiev',
  'Kiev - Odesa'
]
const schedule = [
  {
    direction: 0,
    date: '11.3.2021',
    seats: [
      [ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ],
      [ 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 ],
      [ 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 ],
      [ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ]
    ],
    spaces: [2]
  },
  {
    direction: 1,
    date: '11.3.2021',
    seats: [
      [ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ],
      [ 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 ],
      [ 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 ],
      [ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ]
    ],
    spaces: [2]
  }
];
let selectedDirection = 0;
let selectedDate = null;
let selectedSeats = [];
let ticketsList = [];

function handleSeatClick(e) {
  if (e.target.src) {
    if (e.target.src.indexOf('img/seat-busy.png') !== -1) {
      return;
    }

    let [x, y] = e.target.id.split('_');
    x = parseInt(x), y = parseInt(y);

    if (e.target.src.indexOf('img/seat.png') !== -1) {
      e.target.src = 'img/seat-success.png';

      selectedSeats.push({ x, y });
    } else {
      e.target.src = 'img/seat.png';

      selectedSeats = selectedSeats.filter(s => (s.x === x && s.y === y) ? 0 : 1);
    }
  } 
}

function loadSeats({ seats, spaces }) {
  let seatsEl = document.querySelector('#seats');

  seatsEl.innerHTML = '';
  seatsEl.style.width = `${SEAT_SIZE * seats[0].length}px`;

  for (let y = 0; y < seats.length; y++) {
    spaces.forEach(space => {
      if (y === space) {
        let spaceEl = document.createElement('div');
        spaceEl.style.width = `${SEAT_SIZE * seats[0].length}px`;
        spaceEl.style.height = `${SEAT_SIZE / 2}px`;
  
        seatsEl.appendChild(spaceEl);
      }
    })

    for (let x = 0; x < seats[y].length; x++) {
      let seat = document.createElement('div');
      seat.className = 'seat';
      seat.addEventListener('click', (e) => handleSeatClick(e, x, y));

      let img = document.createElement('img');
      img.id = `${x}_${y}`;
      !seats[y][x] ? img.src = 'img/seat.png' : img.src = 'img/seat-busy.png'
      seat.appendChild(img);
  
      seatsEl.appendChild(seat);
    }
  }
}

function loadDirections() {
  directions.forEach(d => {
    let option = document.createElement('option');
    option.innerText = d;
    direction.appendChild(option);
  })
}

loadDirections();

function loadDates() {
  let today = new Date();

  selectedDate = `${today.getDate()}.${today.getMonth() + 1}.${today.getFullYear()}`;

  for (let i = 0; i < 30; i++) {
    let option = document.createElement('option');
    option.innerText = `${today.getDate()}.${today.getMonth() + 1}.${today.getFullYear()}`;
    date.appendChild(option);

    today.setDate(today.getDate() + 1);
  }

  getSchedule();
}

loadDates();

function getSchedule() {
  let selectedSchedule = schedule.filter(s => s.direction === selectedDirection && s.date === selectedDate);
  
  if (selectedSchedule.length === 1) {
    return loadSeats(selectedSchedule[0]);
  } else {
    let newSchedule = {
      direction: selectedDirection,
      date: selectedDate,
      spaces: [2]
    };

    let seats = [];

    for (let y = 0; y < 4; y++) {
      seats[y] = [];
      
      for (let x = 0; x < 10; x++) {
        seats[y].push(0);
      }
    }

    newSchedule.seats = seats;

    schedule.push(newSchedule);

    return loadSeats(newSchedule);
  }
}

function handleDirectionChanged(e) {
  selectedDirection = directions.indexOf(e.target.value);

  getSchedule();
}

function handleDateChanged(e) {
  selectedDate = e.target.value;

  getSchedule();
}

function handleBook() {
  if (selectedSeats.length > 0) {
    let selectedSchedule = schedule.filter(s => s.direction === selectedDirection && s.date === selectedDate);

    if (selectedSchedule.length > 0) {
      selectedSchedule = selectedSchedule[0];

      selectedSeats.forEach(ss => {
        console.log(ss, selectedSchedule.seats);
        selectedSchedule.seats[ss.y][ss.x] = 1;
        
        // TODO add each ticket to tickets list
        
      });
    }

    console.log(schedule);
  }
}

function hangHandlers() {
  direction.addEventListener('change', handleDirectionChanged);
  date.addEventListener('change', handleDateChanged);
  book.addEventListener('click', handleBook);
}

hangHandlers();