const questions = [
  {
    question: 'Как называется крупнейшая технологическая компания в Южной Корее?',
    answers: [
      {
        answer: 'Huawei'
      },
      {
        answer: 'Samsung',
        right: true
      },
      {
        answer: 'Xiaomi'
      }
    ]
  },
  {
    question: 'Какой металл был открыт Гансом Кристианом Эрстедом в 1825 году?',
    answers: [
      {
        answer: 'Алюминий',
        right: true
      },
      {
        answer: 'Хром',
      },
      {
        answer: 'Медь'
      }
    ]
  },
  {
    question: 'Какая столица Португалии?',
    answers: [
      {
        answer: 'Порту'
      },
      {
        answer: 'Лиссабон',
        right: true
      },
      {
        answer: 'Колимбра'
      }
    ]
  }
];

function getCookie(name) {
  return document.cookie.split(';').filter((item) => item.includes(`${name}=`)).toString().split('=')[1];
}

function handleSubmit(e) {
  e.preventDefault();

  let selectedAnswers = document.querySelectorAll('input[type=radio]:checked');
  let score = 0;

  selectedAnswers.forEach(a => {
    if (a.value === questions.find(q => q.question === a.name).answers.find(a => a.right).answer) {
      score++;
    }
  })

  if (getCookie('tries') > 5) {
    return alert('Вы больше не можете пройти этот тест');
  }

  let name = prompt('Введите ваше имя');

  alert(`Поздравляем, ${name}! Вы сдали тест на ${score} из ${questions.length}`);

  document.cookie = `last_score=${score}`;
  document.cookie = `name=${name}`;

  if (getCookie('tries')) {
    document.cookie = `tries=${parseInt(getCookie('tries')) + 1}`;
  } else {
    document.cookie = `tries=1`;
  }
}

function init() {
  if (getCookie('tries') > 5) {
    return alert('Вы больше не можете пройти этот тест');
  }

  if (getCookie('name') && getCookie('last_score')) {
    alert(`Здравствуйте, ${getCookie('name')}! В прошлый раз вы сдали тест на ${getCookie('last_score')} из ${questions.length}`);
  }

  let questionsComponent = new QuestionsComponent(questions);

  let element = new Component('div', [ questionsComponent ]);

  DOM.render(element, document.getElementById('tests'));

  document.querySelector('#test').onsubmit = handleSubmit;
}

document.onload = init();