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

			var questions1 = new List<Question>
			{
				new Question("Right answer is second one", answers1),
				new Question("The same", answers1),
				new Question("Simmilar one", answers1),
			};

			Tests.Add(new Test("Test #1", questions1));
			Tests.Add(new Test("Test #2", questions1));
			Tests.Add(new Test("Test #3", questions1));
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			foreach (var test in Tests)
			{
				RadioButton button = new RadioButton
				{
					Content = test.Title,
					Tag = test,
					Padding = new Thickness(8)
				};

				button.Click += RadioButtonClick;

				toolBarTests.Items.Add(button);
			}
		}

		private void RadioButtonClick(object sender, RoutedEventArgs e)
		{
			var button = (RadioButton)sender;
			
			tabControlCurrentQuestion.Items.Clear();

			var test = (Test)button.Tag;

			CurrentTest = test;
			CurrentQuestionNum = 0;

			textBlockTestTitle.Text = test.Title;

			for (int i = 0; i < CurrentTest.Questions.Count; i++)
			{
				var question = CurrentTest.Questions[i];

				TabItem tabItem = new TabItem
				{
					IsEnabled = false,
					Header = $"Question #{i + 1}",
					Content = GetTabContent(question)
				};

				if (i == 0)
				{
					tabItem.IsEnabled = true;
					tabItem.IsSelected = true;
				}

				tabControlCurrentQuestion.Items.Add(tabItem);
			}

			tabControlCurrentQuestion.Items.Add(new TabItem
			{
				IsEnabled = false,
				Header = "Results"
			});
		}

		private void SelectAnswer_Click(object sender, RoutedEventArgs e)
		{
			var radioButton = (RadioButton)sender;

			var answer = (Answer)radioButton.Tag;

			//MessageBox.Show(answer.IsRight.ToString());
		}

		private StackPanel GetTabContent(Question question)
		{
			StackPanel stackPanel = new StackPanel()
			{
				Margin = new Thickness(10, 5, 10, 0)
			};

			//bool isCheckBox = false;

			//if (question.Answers.Count(answer => answer.IsRight == true) > 1)
			//{
			//	isCheckBox = true;
			//}

			stackPanel.Children.Add(new TextBlock()
			{
				Text = $"Question #{CurrentQuestionNum + 1}: {question.Text}",
				Margin = new Thickness(0, 8, 0, 5)
			});

			int answerNum = 0;

			for (; answerNum < question.Answers.Count; answerNum++)
			{
				var answer = question.Answers[answerNum];

				RadioButton radioButton = new RadioButton()
				{
					Content = $"Answer #{answerNum}: {answer.Text}",
					Tag = answer,
					Margin = new Thickness(0, 8, 0, 0),
				};

				radioButton.Checked += SelectAnswer_Click;

				stackPanel.Children.Add(radioButton);
			}

			Button button = new Button()
			{
				Content = "Next question",
				Margin = new Thickness(0, 16, 0, 8),
				Tag = answerNum
			};

			button.Click += Button_Click;

			stackPanel.Children.Add(button);

			//tabItem.Content = stackPanel;

			return stackPanel;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			
		}
	}
}
