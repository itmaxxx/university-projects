const checkEmail = (e) => {
  const text = e.target.value;
  const output = text.match(/^([a-z][a-z_1-9]{2,15})@([a-z\.]+\.[a-z]{2,3})$/i);

  if (output) {
    result.innerText = `Login: ${output[1]}\nHost: ${output[2]}`;
    result.style.color = 'black';
  } else {
    result.innerText = 'Email не соотвествует формату login@host';
    result.style.color = 'red';
  }
}

email.oninput = checkEmail;