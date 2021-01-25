using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Calendar
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        public Year CurrentYear { get; set; }
        public ObservableCollection<Week> CurrentMonth { get; set; }
        public string CurrentMonthName { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentYear = new Year();

            CurrentMonthName = "December";

            UpdateMonth(CurrentYear.Months[11]);
        }

        private void RadioButtonMonth_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = (RadioButton)sender;

            int selectedMonthTag = (int)(MonthsNames)Convert.ToInt32(radioButton.Tag);

            Month selectedMonth = CurrentYear.Months[selectedMonthTag - 1];

            CurrentMonthName = selectedMonth.Name.ToString();

            UpdateMonth(selectedMonth);
        }

        private void UpdateMonth(Month month)
        {
            CurrentMonth = new ObservableCollection<Week>();

            var currentWeek = new Week();

            for (int i = 0; i < month.Days.Count; i++)
            {
                string dayStr = month.Days[i].Number.ToString();

                switch (month.Days[i].DayOfTheWeek)
                {
                    case DaysOfTheWeek.Monday:
                        currentWeek.Monday = dayStr;
                        break;
                    case DaysOfTheWeek.Tuesday:
                        currentWeek.Tuesday = dayStr;
                        break;
                    case DaysOfTheWeek.Wednesday:
                        currentWeek.Wednesday = dayStr;
                        break;
                    case DaysOfTheWeek.Thursday:
                        currentWeek.Thursday = dayStr;
                        break;
                    case DaysOfTheWeek.Friday:
                        currentWeek.Friday = dayStr;
                        break;
                    case DaysOfTheWeek.Saturday:
                        currentWeek.Saturday = dayStr;
                        break;
                    case DaysOfTheWeek.Sunday:
                        currentWeek.Sunday = dayStr;
                        break;
                }

                if ((i == month.Days.Count - 1 && month.Days[i].DayOfTheWeek != DaysOfTheWeek.Sunday) 
                    || month.Days[i].DayOfTheWeek == DaysOfTheWeek.Sunday)
                {
                    CurrentMonth.Add(currentWeek);

                    currentWeek = new Week();
                }
            }

            listViewCurrentMonth.ItemsSource = CurrentMonth;
            textBlockCurrentMonthName.Text = CurrentMonthName;
        }

        private void ButtonSelectDay_Click(object sender, RoutedEventArgs e)
		{
            var button = (Button)sender;

            if (button.Background == Brushes.Transparent)
			{
                button.Background = Brushes.Red;
                button.Foreground = Brushes.White;
            }
            else if (button.Background == Brushes.Red)
			{
                button.Background = Brushes.Green;
                button.Foreground = Brushes.White;
            }
            else if (button.Background == Brushes.Green)
            {
                button.Background = Brushes.Blue;
                button.Foreground = Brushes.White;
            }
            else if (button.Background == Brushes.Blue && button.FontWeight == FontWeights.Bold)
            {
                button.Background = Brushes.Transparent;
                button.Foreground = Brushes.Red;
            }
            else
            {
                button.Background = Brushes.Transparent;
                button.Foreground = Brushes.Black;
            }

            if (button.Content.ToString().Length == 0)
            {
                return; 
            }                

            //MessageBox.Show($"{button.Content.ToString()} of {CurrentMonthName}");
		}
	}
}
