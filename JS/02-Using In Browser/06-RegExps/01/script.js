const checkFIO = (e) => {
  const text = e.target.value;
  const output = text.match(/([а-яА-Я]+) ([А-Я])\.?([А-Я])\.?/);

  if (output) {
    result.innerText = `Фамилия: ${output[1]}\nПервая буква имени: ${output[2]}\nПервая буква отчества: ${output[3]}`;
    result.style.color = 'black';
  } else {
    result.innerText = 'ФИО не соотвествует формату Фамилия И.О.';
    result.style.color = 'red';
  }
}

fio.oninput = checkFIO;