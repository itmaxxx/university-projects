function handleExit() {
  localStorage.removeItem('email');
  localStorage.removeItem('password');
  
  localStorage.removeItem('firstName');
  localStorage.removeItem('lastName');
  localStorage.removeItem('yearOfBirth');
  localStorage.removeItem('gender');
  localStorage.removeItem('phoneNumber');
  localStorage.removeItem('skype');

  document.location.href = 'index.html';
}

function handleFormSubmit(e) {
  e.preventDefault();

  let firstName = document.querySelector('#firstName').value;
  let lastName = document.querySelector('#lastName').value;
  let yearOfBirth = document.querySelector('#yearOfBirth').value;
  let gender = document.querySelector('#gender').value;
  let phoneNumber = document.querySelector('#phoneNumber').value;
  let skype = document.querySelector('#skype').value;

  localStorage.setItem('firstName', firstName);
  localStorage.setItem('lastName', lastName);
  localStorage.setItem('yearOfBirth', yearOfBirth);
  localStorage.setItem('gender', gender);
  phoneNumber.length !== 0 && localStorage.setItem('phoneNumber', phoneNumber);
  skype.length !== 0 && localStorage.setItem('skype', skype);
}

const setSaveDisabled = (state) => {
  document.querySelector('#save').disabled = state;
}

function notValidated(field) {
  if (field.className.indexOf('is-valid') !== -1) {
    field.className = field.className.replace(' is-valid', '');
  }

  if (field.className.indexOf('is-invalid') === -1) {
    field.className += ' is-invalid'
  }

  setSaveDisabled(true);
}

function validated(field) {
  if (field.className.indexOf('is-invalid') !== -1) {
    field.className = field.className.replace(' is-invalid', '');
  }

  if (field.className.indexOf('is-valid') === -1) {
    field.className += ' is-valid'
  }

  setSaveDisabled(false);
}

function checkName(value) {
  return value.match(/^[A-zА-я]{1,20}$/);
}

function handleFirstName(e) {
  let firstNameField = document.querySelector('#firstName');
  let firstNameError = document.querySelector('#invalidFirstName');

  if (checkName(e.target.value)) {
    validated(firstNameField);
  } else {
    if (e.target.value.length > 20) {
      firstNameError.innerText = 'Max first name length is 20 symbols';
    } else {
      firstNameError.innerText = 'Only letters allowed';
    }

    notValidated(firstNameField);
  }
}

function handleLastName(e) {
  let lastNameField = document.querySelector('#lastName');
  let lastNameError = document.querySelector('#invalidLastName');

  if (checkName(e.target.value)) {
    validated(lastNameField);
  } else {
    if (e.target.value.length > 20) {
      lastNameError.innerText = 'Max last name length is 20 symbols';
    } else {
      lastNameError.innerText = 'Only letters allowed';
    }

    notValidated(lastNameField);
  }
}

function checkYearOfBirth(value) {
  return value.match(/^[0-9]{4}$/);
}

function handleYearOfBirth(e) {
  let yearOfBirthField = document.querySelector('#yearOfBirth');
  let yearOfBirthError = document.querySelector('#invalidYearOfBirth');

  if (checkYearOfBirth(e.target.value) && parseInt(e.target.value) >= 1900 && parseInt(e.target.value) <= new Date().getFullYear()) {
    validated(yearOfBirthField);
  } else {
    if (parseInt(e.target.value) < 1900) {
      yearOfBirthError.innerText = 'Year should be bigger than 1900';
    } else if (parseInt(e.target.value) > new Date().getFullYear()) {
      yearOfBirthError.innerText = `Year shold be lower than ${new Date().getFullYear()}`;
    } else {
      yearOfBirthError.innerText = `Only digits allowed`;
    }

    notValidated(yearOfBirthField);
  }
}

function checkPhoneNumber(value) {
  return value.match(/^[0-9 \(\)\-+]+$/);
}

function handlePhoneNumber(e) {
  let phoneNumberField = document.querySelector('#phoneNumber');
  let phoneNumberError = document.querySelector('#invalidPhoneNumber');
  let phoneDigits = (phoneNumberField.value.match(/[0-9]/g) || []).join('');

  if (checkPhoneNumber(e.target.value) && phoneDigits.length >= 10 && phoneDigits.length <= 12) {
    validated(phoneNumberField);
  } else {
    if (phoneDigits.length < 10) {
      phoneNumberError.innerText = 'Digits count should be higher than 10';
    } else if (phoneDigits.length > 12) {
      phoneNumberError.innerText = 'Digits count should be lower than 12';
    } else {
      phoneNumberError.innerText = 'Phone number can only contain digits, \'()\', \'+\' and \'-\'';
    }

    notValidated(phoneNumberField);
  }
}

function checkSkype(value) {
  return value.match(/^[A-zА-я0-9-.]+$/);
}

function handleSkype(e) {
  let skypeField = document.querySelector('#skype');

  if (checkSkype(e.target.value)) {
    validated(skypeField);
  } else {
    notValidated(skypeField);
  }
}

function loadData() {
  document.querySelector('#firstName').value = localStorage.getItem('firstName');
  document.querySelector('#lastName').value = localStorage.getItem('lastName');
  document.querySelector('#yearOfBirth').value = localStorage.getItem('yearOfBirth');
  document.querySelector('#gender').value = localStorage.getItem('gender');
  document.querySelector('#phoneNumber').value = localStorage.getItem('phoneNumber');
  document.querySelector('#skype').value = localStorage.getItem('skype');
}

function init() {
  if (!localStorage.getItem('email') && !localStorage.getItem('password')) {
    document.location.href = 'index.html'
  }

  loadData();

  document.querySelector('#email').innerText = localStorage.getItem('email');
  document.querySelector('#exit').addEventListener('click', handleExit);

  document.querySelector('#firstName').addEventListener('input', handleFirstName);
  document.querySelector('#lastName').addEventListener('input', handleLastName);
  document.querySelector('#yearOfBirth').addEventListener('input', handleYearOfBirth);
  document.querySelector('#phoneNumber').addEventListener('input', handlePhoneNumber);
  document.querySelector('#skype').addEventListener('input', handleSkype);

  document.querySelector('#userInfoForm').addEventListener('submit', handleFormSubmit);
}

init();