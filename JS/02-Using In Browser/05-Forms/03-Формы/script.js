function register() {
  let login = document.querySelector('input[name=login]');
  let text_password1 = document.querySelector('input[name=text_password1]');
  let text_password2 = document.querySelector('input[name=text_password2]');
  let fullname = document.querySelector('input[name=fullname]');
  let radio_gender = document.querySelector('input[name=radio_gender]:checked');
  let check_languages = [ 
                          document.querySelector('input[name=check_languages_1]:checked'),
                          document.querySelector('input[name=check_languages_2]:checked'),
                          document.querySelector('input[name=check_languages_3]:checked'),
                          document.querySelector('input[name=check_languages_4]:checked'),
                          document.querySelector('input[name=check_languages_5]:checked')
                        ];
  let list_work = document.querySelector('select[name=list_work]');
  let e_mail = document.querySelector('input[name=e_mail]');
  let text_info = document.querySelector('textarea[name=text_info]');

  if (login.value.length >= 3 && login.value.length <= 10) {
    document.cookie = `login=${login.value}`;
  } else {
    return alert('Длина логина должна быть от 3 до 10 символов');
  }

  if (text_password1.value.length >= 3 && text_password1.value.length <= 10) {
    if (text_password2.value.length >= 3 && text_password2.value.length <= 10) {
      if (text_password1.value === text_password2.value) {
        document.cookie = `password=${text_password1.value}`;
      } else {
        return alert('Пароли не совпадают');
      }
    } else {
      return alert('Пароль должен быть от 3 до 10 символов');
    }
  } else {
    return alert('Пароль должен быть от 3 до 10 символов');
  }

  if (fullname.value.length >= 3) {
    document.cookie = `fullname=${fullname.value}`;
  } else {
    return alert('Длина имени должна быть от 3 символов');
  }

  if (radio_gender) {
    document.cookie = `radio_gender=${radio_gender.value}`;
  } else {
    return alert('Выберите ваш пол');
  }

  if (check_languages.filter(e => e).length > 0) {
    for (let i = 1; i <= check_languages.length; i++) {
      if (check_languages[i - 1]) {
        document.cookie = `check_languages_${i}=true`;
      } else {
        document.cookie = `check_languages_${i}=false; max-age=0`;
      }
    }
  } else {
    return alert('Выберите хотябы 1 иностранный язык');
  }

  if (list_work?.value) {
    document.cookie = `list_work=${list_work.value}`;
  } else {
    return alert('Выберите иностранные языки');
  }

  if (e_mail.value.length > 3) {
    document.cookie = `e_mail=${e_mail.value}`;
  } else {
    return alert('Длина почты должна быть от 3 символов');
  }

  if (text_info.value.length > 0) {
    document.cookie = `text_info=${text_info.value}`;
  }
}

function reset() {
  document.cookie = `login=false; max-age=0`;
  document.cookie = `password=false; max-age=0`;
  document.cookie = `fullname=false; max-age=0`;
  document.cookie = `radio_gender=false; max-age=0`;

  for (let i = 1; i <= 5; i++) {
    document.cookie = `check_languages_${i}=false; max-age=0`;
  }

  document.cookie = `list_work=false; max-age=0`;
  document.cookie = `e_mail=false; max-age=0`;
  document.cookie = `text_info=false; max-age=0`;
}

function getCookie(name) {
  return document.cookie.split(';').filter((item) => item.includes(`${name}=`)).toString().split('=')[1];
}

function init() {
  if (getCookie('login')) {
    document.querySelector('input[name=login]').value = getCookie('login');
  }

  if (getCookie('password')) {
    document.querySelector('input[name=text_password1]').value = getCookie('password');
    document.querySelector('input[name=text_password2]').value = getCookie('password');
  }

  if (getCookie('fullname')) {
    document.querySelector('input[name=fullname]').value = getCookie('fullname');
  }

  if (getCookie('gender')) {
    document.querySelector(`input[name=radio_gender][value=${getCookie('gender')}]`).checked = true;
  }

  for (let i = 0; i < 5; i++) {
    if (getCookie(`check_languages_${i + 1}`)) {
      document.querySelector(`input[name=check_languages_${i + 1}]`).checked = true;
    }
  }

  if (getCookie('e_mail')) {
    document.querySelector('input[name=e_mail]').value = getCookie('e_mail');
  }

  if (getCookie('text_info')) {
    document.querySelector('textarea[name=text_info]').value = getCookie('text_info');
  }

  document.querySelector('#register').addEventListener('click', register);
  document.querySelector('#reset').addEventListener('click', reset);
}

init();