using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestsApp.Classes;

namespace TestsApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>

	public partial class MainWindow : Window
	{
		public List<Test> Tests { get; set; }
		public Test CurrentTest { get; set; }
		public int CurrentQuestionNum { get; set; }
		public int RightAnswers { get; set; }
		public List<Answer> SelectedAnswers { get; set; }

		public MainWindow()
		{
			InitializeComponent();

			Tests = new List<Test>();

			FillTests();
		}

		private void FillTests()
		{
			var answers1 = new List<Answer>
			{
				new Answer("Not right", false),
				new Answer("I'm right", true),
				new Answer("I'm false", false)
			};

			var answers2 = new List<Answer>
			{
				new Answer("Not right", false),
				new Answer("I'm right", true),
				new Answer("I'm right too", true)
			};

			var questions1 = new List<Question>
			{
				new Question("How old are you?", answers1),
				new Question("What is your name?", answers2),
				new Question("How is the weather today?", answers1),
			};

			var questions2 = new List<Question>
			{
				new Question("Right answer is second one", answers2),
				new Question("The same", answers2),
				new Question("Simmilar one", answers1),
			};

			Tests.Add(new Test("Test #1", questions1));
			Tests.Add(new Test("Test #2", questions2));
			Tests.Add(new Test("Test #3", questions1));
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			foreach (var test in Tests)
			{
				RadioButton radioButton = new RadioButton
				{
					Content = test.Title,
					Tag = test,
					Padding = new Thickness(8)
				};

				radioButton.Click += RadioButtonSelectTest_Click;

				toolBarTests.Items.Add(radioButton);
			}
		}

		private void RadioButtonSelectTest_Click(object sender, RoutedEventArgs e)
		{
			var radioButton = sender as RadioButton;
			
			tabControlCurrentQuestion.Items.Clear();

			var test = radioButton.Tag as Test;

			CurrentTest = test;
			CurrentQuestionNum = 0;
			RightAnswers = 0;

			textBlockTestTitle.Text = test.Title;

			for (int i = 0; i < CurrentTest.Questions.Count; i++)
			{
				var question = CurrentTest.Questions[i];

				TabItem tabItem = new TabItem
				{
					IsEnabled = true,
					Header = $"Question #{i + 1}",
					Content = GetTabContent(question)
				};

				// Select first question
				if (i == 0)
				{
					tabItem.IsSelected = true;
				}

				tabControlCurrentQuestion.Items.Add(tabItem);
			}
		}

		private StackPanel GetTabContent(Question question)
		{
			StackPanel stackPanel = new StackPanel()
			{
				Margin = new Thickness(10, 5, 10, 0),
				VerticalAlignment = VerticalAlignment.Stretch
			};

			bool isCheckBox = false;

			if (question.Answers.Count(answer => answer.IsRight == true) > 1)
			{
				isCheckBox = true;
			}

			stackPanel.Children.Add(new TextBlock()
			{
				Text = $"Question #{CurrentQuestionNum + 1}: {question.Text}",
				FontSize = 16,
				FontWeight = FontWeights.SemiBold,
				Margin = new Thickness(0, 8, 0, 5)
			});

			int answerNum = 0;

			for (; answerNum < question.Answers.Count; answerNum++)
			{
				var answer = question.Answers[answerNum];

				if (isCheckBox)
				{
					CheckBox checkBox = new CheckBox()
					{
						Content = $"Answer #{answerNum}: {answer.Text}",
						Tag = answer,
						Margin = new Thickness(0, 8, 0, 0),
					};

					checkBox.Checked += CheckBoxAnswer_Checked;
					checkBox.Unchecked += CheckBoxAnswer_Unchecked;

					stackPanel.Children.Add(checkBox);
				} else
				{
					RadioButton radioButton = new RadioButton()
					{
						Content = $"Answer #{answerNum}: {answer.Text}",
						Tag = answer,
						Margin = new Thickness(0, 8, 0, 0),
					};

					radioButton.Checked += RadioButtonAnswer_Checked;
					radioButton.Unchecked += RadioButtonAnswer_Unchecked;

					stackPanel.Children.Add(radioButton);
				}
			}

			Button button = new Button()
			{
				Content = "Submit answer(s)",
				Margin = new Thickness(0, 16, 0, 8),
				Tag = answerNum
			};

			button.Click += ButtonSubmitAnswers_Click;

			stackPanel.Children.Add(button);

			return stackPanel;
		}

		private void CheckBoxAnswer_Unchecked(object sender, RoutedEventArgs e)
		{
			var checkBox = sender as CheckBox;

			SelectedAnswers.Remove(checkBox.Tag as Answer);
		}

		private void CheckBoxAnswer_Checked(object sender, RoutedEventArgs e)
		{
			var checkBox = sender as CheckBox;

			var answer = checkBox.Tag as Answer;

			if (SelectedAnswers == null)
			{
				SelectedAnswers = new List<Answer>();
			}

			SelectedAnswers.Add(answer);
		}

		private void RadioButtonAnswer_Unchecked(object sender, RoutedEventArgs e)
		{
			var radioButton = sender as RadioButton;

			SelectedAnswers.Remove(radioButton.Tag as Answer);
		}

		private void RadioButtonAnswer_Checked(object sender, RoutedEventArgs e)
		{
			var radioButton = sender as RadioButton;

			var answer = radioButton.Tag as Answer;

			if (SelectedAnswers == null)
			{
				SelectedAnswers = new List<Answer>();
			}

			SelectedAnswers.Add(answer);
		}

		private void ButtonSubmitAnswers_Click(object sender, RoutedEventArgs e)
		{
			if (SelectedAnswers == null)
			{
				MessageBox.Show("Select the answer(s)");

				return;
			}

			CurrentQuestionNum++;

			foreach (var answer in SelectedAnswers)
			{
				if (answer.IsRight)
				{
					RightAnswers++;
				}
			}

			// Clear answers array
			SelectedAnswers = null;

			for (int i = 0; i < tabControlCurrentQuestion.Items.Count - 1; i++)
			{
				if (i <= tabControlCurrentQuestion.SelectedIndex)
				{
					(tabControlCurrentQuestion.Items[i] as TabItem).IsEnabled = false;
				}
			}

			if (tabControlCurrentQuestion.SelectedIndex == tabControlCurrentQuestion.Items.Count - 1)
			{
				(tabControlCurrentQuestion.SelectedItem as TabItem).IsEnabled = false;

				int totalRightAnswersCount = 0;

				foreach (var question in CurrentTest.Questions)
				{
					foreach (var answer in question.Answers)
					{
						if (answer.IsRight)
						{
							totalRightAnswersCount++;
						}
					}
				}

				var stackPanel = new StackPanel()
				{
					Margin = new Thickness(10)
				};

				int rightAnswersPercent = 100 / totalRightAnswersCount * RightAnswers;

				stackPanel.Children.Add(new TextBlock()
				{
					Text = $"{rightAnswersPercent}%",
					FontSize = 46,
					FontWeight = FontWeights.SemiBold,
					Foreground = rightAnswersPercent < 50 ? Brushes.Red : rightAnswersPercent >= 50 && rightAnswersPercent < 75 ? Brushes.Orange : Brushes.Green,
					TextAlignment = TextAlignment.Center
				});

				stackPanel.Children.Add(new TextBlock()
				{
					Text = $"{RightAnswers} right answer(s) from {totalRightAnswersCount} possible answer(s)",
					FontSize = 18,
					Foreground = Brushes.Black,
					TextAlignment = TextAlignment.Center
				});

				stackPanel.Children.Add(new TextBlock()
				{
					Text = $"in {CurrentQuestionNum} question(s)",
					FontSize = 18,
					Foreground = Brushes.Black,
					TextAlignment = TextAlignment.Center
				});

				tabControlCurrentQuestion.Items.Add(new TabItem
				{
					IsEnabled = true,
					Header = "Test results",
					Content = stackPanel
				});
			}

			tabControlCurrentQuestion.SelectedIndex++;
		}
	}
}
