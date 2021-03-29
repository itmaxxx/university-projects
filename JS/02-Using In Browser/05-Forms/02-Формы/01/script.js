function check() {
  let username = document.querySelector('#username');
  let password = document.querySelector('#password');
  let repeatpassword = document.querySelector('#repeatpassword');
  let fullname = document.querySelector('#fullname');
  let gender = document.querySelector('input[name=gender]:checked');
  let specialization = document.querySelectorAll('input[name=specialization]:checked');

  if (username.value.length === 0)
    return alert('Введите логин');
  if (username.value.length < 3)
    return alert('Длина логина должна быть от 3 символов');

  if (password.value.length < 3)
    return alert('Длина пароля должна быть от 3 символов');
  if (password.value.length > 10)
    return alert('Длина пароля должна быть до 10 символов');

  if (password.value !== repeatpassword.value)
    return alert('Пароли должны совпадать');

  if (fullname.value.length === 0)
    return alert('Введите полное имя');

  if (!gender)
    return alert('Выберите ваш пол');

  if (specialization.length === 0)
    return alert('Выберите специализацию');

  return true;
}

function register(e) {
  e.preventDefault();
  
  if (check()) {
    let username = document.querySelector('#username').value;
    let fullname = document.querySelector('#fullname').value;
    let gender = document.querySelector('input[name=gender]:checked').value;
    let specializations = '';
    let position = document.querySelector('#position').value;

    Array.from(document.querySelectorAll('input[name=specialization]:checked')).forEach(e => specializations += `${e.value.toLowerCase()} `);
    specializations = specializations.charAt(0).toUpperCase() + specializations.slice(1);
    
    let result = window.open('./result.html', '_blank');
    result.user = {
      username,
      fullname,
      gender,
      specializations,
      position
    };
    result.focus();
  }
}

function reset(e) {
  e.preventDefault();

  let username = document.querySelector('#username');
  let password = document.querySelector('#password');
  let repeatpassword = document.querySelector('#repeatpassword');
  let fullname = document.querySelector('#fullname');

  username.value = '';
  password.value = '';
  repeatpassword.value = '';
  fullname.value = '';
}

function init() {
  document.getElementById('register').addEventListener('click', register);
  document.getElementById('reset').addEventListener('click', reset);
}

init();