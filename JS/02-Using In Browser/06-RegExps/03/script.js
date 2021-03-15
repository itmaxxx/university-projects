const checkDate = (e) => {
  const text = e.target.value;
  const output = text.match(/(\d{2})-(\d{2})-(\d{4})/);

  if (output) {
    let rightDate = new Date(output[3], output[2], output[1], );

    // result.innerText = `День: ${output[1]}\nМесяц: ${output[2]}\nГод: ${output[3]}`;
    result.innerText = `День: ${rightDate.getDate()}\nМесяц: ${rightDate.getMonth()}\nГод: ${rightDate.getFullYear()}`;
    result.style.color = 'black';
  } else {
    result.innerText = 'Дата не соотвествует формату dd-mm-yyyy';
    result.style.color = 'red';
  }
}

date.oninput = checkDate;