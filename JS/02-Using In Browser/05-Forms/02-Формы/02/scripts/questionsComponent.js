class QuestionsComponent extends Component { 
  constructor(questions) {
    super();

    this.questions = questions;
  }

  render() {
    let questionsQuestionsEl = [];

    this.questions.forEach(q => {
      questionsQuestionsEl.push(new QuestionComponent(q.question, q.answers));
    });

    let questionsEl = new Component('div', questionsQuestionsEl, { className: 'questions' });

    return questionsEl.render();
  }
}