function getCurrentMonthDays() {
  let tempDate = new Date();
  tempDate.setMonth(tempDate.getMonth() + 1);
  tempDate.setDate(0);

  return tempDate.getDate();
}

function getCurrentMonthFirstDay() {
  let tempDate = new Date();
  tempDate.setDate(1);

  return tempDate.getDay();
}

function getDateDayOfTheWeek(date, day) {
  date.setDate(day);

  return date.getDay();
}

function isWeekDay(date, day) {
  let dayOfTheWeek = getDateDayOfTheWeek(date, day);

  return (dayOfTheWeek === 0 || dayOfTheWeek === 6);
}

function getPartOfTheYear(date) {
  let month = date.getMonth();

  if ((month >= 0 && month < 2) || month === 11) {
    return 1;
  } else if (month >= 2 && month < 5) {
    return 2;
  } else if (month >= 5 && month < 9) {
    return 3;
  } else {
    return 4;
  }

  return 3;
}

function loadDate() {
  let today = new Date();
  let month = today.toLocaleString('en', { month: 'long' })
  month = month[0].toUpperCase() + month.substr(1);

  document.getElementById('monthName').innerText = month;

  // Add 'spaces' days
  let monthDays = document.getElementById('monthDays');
  
  for (let i = 1; i < getCurrentMonthFirstDay(); i++) {
    let day = document.createElement('div');
    day.className = 'day';
    
    monthDays.appendChild(day);
  }
  
  // Add month days
  let days = getCurrentMonthDays();

  for (let i = 1; i <= days; i++) {
    let day = document.createElement('div');
    day.className = `day${isWeekDay(today, i) ? ' weekend' : ''}`;
    day.innerText = i;

    monthDays.appendChild(day);
  }

  // Get background
  document.getElementsByClassName('app')[0].style.backgroundImage = `url('img/${getPartOfTheYear(today)}.JPG')`;
}

loadDate();