class QuestionComponent extends Component {
  constructor(question, answers) {
    super();

    this.question = question;
    this.answers = answers;
  }

  render() {
    let questionQuestionEl = new Component('p', [ this.question ], { className: 'question__question' });
    
    let answersArray = []

    this.answers.forEach(a => {
      let answerEl = new Component('input', [  ], { className: 'question__answer-radio', type: 'radio', name: `${this.question}`, value: a.answer });      

      answersArray.push(new Component('label', [ answerEl, a.answer ], { className: 'question__answer' }));
    });

    let questionEl = new Component('div', [ questionQuestionEl, ...answersArray ], { className: 'question' });

    return questionEl.render();
  }
}