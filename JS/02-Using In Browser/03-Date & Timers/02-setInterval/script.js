function loadDate() {
  let date = new Date();
  let hours = date.getHours().toString(),
    minutes = date.getMinutes().toString(),
    seconds = date.getSeconds().toString();

  if (hours[0]) {
    hoursFirst.setAttribute('src', `/img/${hours[0]}.gif`);
  }
  if (hours[1]) {
    hoursSecond.setAttribute('src', `/img/${hours[1]}.gif`);
  }

  if (minutes[0]) {
    minutesFirst.setAttribute('src', `/img/${minutes[0]}.gif`);
  }
  if (minutes[1]) {
    minutesSecond.setAttribute('src', `/img/${minutes[1]}.gif`);
  }

  if (seconds[0]) {
    secondsFirst.setAttribute('src', `/img/${seconds[0]}.gif`);
  }
  if (seconds[1]) {
    secondsSecond.setAttribute('src', `/img/${seconds[1]}.gif`);
  }
}

function setupTimer() {
  loadDate();

  setInterval(() => {
    loadDate();
  }, 1000);
}

setupTimer();