function loadDate() {
  let date = new Date();
  let hours = date.getHours().toString(),
    minutes = date.getMinutes().toString(),
    seconds = date.getSeconds().toString();

  if (hours[0]) {
    hoursFirst.setAttribute('src', `/img/${hours[0]}.gif`);
  } else {
    hoursFirst.setAttribute('src', `/img/blank.gif`);
  }
  if (hours[1]) {
    hoursSecond.setAttribute('src', `/img/${hours[1]}.gif`);
  } else {
    hoursSecond.setAttribute('src', `/img/blank.gif`);
  }

  if (minutes[0]) {
    minutesFirst.setAttribute('src', `/img/${minutes[0]}.gif`);
  } else {
    minutesFirst.setAttribute('src', `/img/blank.gif`);
  }
  if (minutes[1]) {
    minutesSecond.setAttribute('src', `/img/${minutes[1]}.gif`);
  } else {
    minutesSecond.setAttribute('src', `/img/blank.gif`);
  }

  if (seconds[0]) {
    secondsFirst.setAttribute('src', `/img/${seconds[0]}.gif`);
  } else {
    secondsFirst.setAttribute('src', `/img/blank.gif`);
  }
  if (seconds[1]) {
    secondsSecond.setAttribute('src', `/img/${seconds[1]}.gif`);
  } else {
    secondsSecond.setAttribute('src', `/img/blank.gif`);
  }
}

function setupTimer() {
  loadDate();

  setInterval(() => {
    loadDate();
  }, 1000);
}

setupTimer();