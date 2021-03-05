function loadDate() {
  let date = new Date();
  let hours = date.getHours().toString(),
    minutes = date.getMinutes().toString(),
    seconds = date.getSeconds().toString();

  if (hours[0] && hours[1]) {
    hoursFirst.setAttribute('src', `/img/${hours[0]}.gif`);
  } else {
    hoursFirst.setAttribute('src', `/img/0.gif`);
  }
  if (hours[1]) {
    hoursSecond.setAttribute('src', `/img/${hours[1]}.gif`);
  } else if (hours[0]) {
    hoursSecond.setAttribute('src', `/img/${hours[0]}.gif`);
  } else {
    hoursSecond.setAttribute('src', `/img/0.gif`);
  }

  if (minutes[0] && minutes[1]) {
    minutesFirst.setAttribute('src', `/img/${minutes[0]}.gif`);
  } else {
    minutesFirst.setAttribute('src', `/img/0.gif`);
  }
  if (minutes[1]) {
    minutesSecond.setAttribute('src', `/img/${minutes[1]}.gif`);
  } else if (minutes[0]) {
    minutesSecond.setAttribute('src', `/img/${minutes[0]}.gif`);
  } else {
    minutesSecond.setAttribute('src', `/img/0.gif`);
  }

  if (seconds[0] && seconds[1]) {
    secondsFirst.setAttribute('src', `/img/${seconds[0]}.gif`);
  } else {
    secondsFirst.setAttribute('src', `/img/0.gif`);
  }
  if (seconds[1]) {
    secondsSecond.setAttribute('src', `/img/${seconds[1]}.gif`);
  } else if (seconds[0]) {
    secondsSecond.setAttribute('src', `/img/${seconds[0]}.gif`);
  } else {
    secondsSecond.setAttribute('src', `/img/0.gif`);
  }
}

function setupTimer() {
  loadDate();

  setInterval(() => {
    loadDate();
  }, 1000);
}

setupTimer();