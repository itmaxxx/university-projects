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

let timer;
let seconds = 0;

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

  let name = prompt('Введите ваше имя');

  alert(`Поздравляем, ${name}! Вы сдали тест на ${score} из ${questions.length} за ${seconds} секунды`);

  clearInterval(timer);
}

function init() {
  let timeCounter = document.querySelector('#time_elapsed');

  timer = setInterval(() => {
    seconds++;

    timeCounter.innerText = `Времени прошло: ${seconds} сек`;
  }, 1000);

  let questionsComponent = new QuestionsComponent(questions);

  let element = new Component('div', [ questionsComponent ]);

  DOM.render(element, document.getElementById('tests'));

  document.querySelector('#test').onsubmit = handleSubmit;
}

document.onload = init();