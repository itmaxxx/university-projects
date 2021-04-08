function handleSubmit(e) {
  e.preventDefault();

  let email = document.querySelector('#email').value;
  let password = document.querySelector('#password').value;

  localStorage.setItem('email', email);
  localStorage.setItem('password', password);

  document.location.href = 'profile.html';
}

const setSignUpDisabled = (state) => {
  document.querySelector('#signUp').disabled = state;
}

function notValidated(field) {
  if (field.className.indexOf('is-valid') !== -1) {
    field.className = field.className.replace(' is-valid', '');
  }

  if (field.className.indexOf('is-invalid') === -1) {
    field.className += ' is-invalid'
  }

  setSignUpDisabled(true);
}

function validated(field) {
  if (field.className.indexOf('is-invalid') !== -1) {
    field.className = field.className.replace(' is-invalid', '');
  }

  if (field.className.indexOf('is-valid') === -1) {
    field.className += ' is-valid'
  }

  setSignUpDisabled(false);
}

const checkEmail = (email) => {
  return email.match(/^([a-z][a-z_\-.0-9]{2,15})@([a-z\.]+\.[a-z]{2,6})$/i);
}

function handleEmail(e) {
  let emailField = document.querySelector('#email');

  if (checkEmail(e.target.value)) {
    validated(emailField);
  } else {
    notValidated(emailField);
  }
}

const checkPassword = (password) => {
  return password.match(/[A-Z]/) && password.match(/[a-z]/) && password.match(/[a-z]/);
}

function handlePassword(e) {
  let passwordField = document.querySelector('#password');
  let passowordError = document.querySelector('#invalidPassword');

  if (checkPassword(e.target.value)) {
    validated(passwordField);
  } else {
    if (e.target.value.length < 6) {
      passowordError.innerText = 'Password length must be at least 6 symbols';
    } else {
      passowordError.innerText = 'Password must have at least 1 uppercase and 1 lowercase letter, and 1 number';
    }

    notValidated(passwordField);
  }
}

function handleRepeatPassword(e) {
  let passwordField = document.querySelector('#password');
  let repeatPasswordField = document.querySelector('#repeatPassword');

  if (passwordField.value === repeatPasswordField.value) {
    validated(repeatPasswordField);
  } else {
    notValidated(repeatPasswordField);
  }
}

function init() {
  if (localStorage.getItem('email') && localStorage.getItem('password')) {
    document.location.href = 'profile.html'
  }

  document.querySelector('#registerForm').addEventListener('submit', handleSubmit);

  document.querySelector('#email').addEventListener('input', handleEmail);
  document.querySelector('#password').addEventListener('input', handlePassword);
  document.querySelector('#repeatPassword').addEventListener('input', handleRepeatPassword);
}

init();