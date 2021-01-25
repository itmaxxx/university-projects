using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
        private List<SelectedDay> SelectedDays { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SelectedDays = new List<SelectedDay>();

            try
			{
                TextReader tr = new StreamReader("calendar.txt");

                int selectedDaysCount = Convert.ToInt32(tr.ReadLine());

				for (int i = 0; i < selectedDaysCount; i++)
				{
                    string monthName = tr.ReadLine();
                    int number = Convert.ToInt32(tr.ReadLine());
                    int priority = Convert.ToInt32(tr.ReadLine());

                    SelectedDays.Add(new SelectedDay(number, monthName, priority));
                }
            } catch(Exception)
			{

			}

            // Generate calendar
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

        private SelectedDay GetIfDaySelected(int number)
		{
            var day = SelectedDays.Find(selectedDay => selectedDay.MonthName == CurrentMonthName && selectedDay.Number == number);

            if (day != null)
			{
                return day;
            }

            return new SelectedDay();
		}

        private void UpdateMonth(Month month)
        {
            CurrentMonth = new ObservableCollection<Week>();

            var currentWeek = new Week();

            for (int i = 0; i < month.Days.Count; i++)
            {
                string dayStr = month.Days[i].Number.ToString();
                var dayIfSelected = GetIfDaySelected(month.Days[i].Number);

                switch (month.Days[i].DayOfTheWeek)
                {
                    case DaysOfTheWeek.Monday:
                        currentWeek.Monday = dayStr;

                        if (dayIfSelected.Priority == 1)
						{
                            currentWeek.MondaySelectionBg = Brushes.Red;
                            currentWeek.MondaySelectionFg = Brushes.White;
						} 
                        else if (dayIfSelected.Priority == 2)
                        {
                            currentWeek.MondaySelectionBg = Brushes.Green;
                            currentWeek.MondaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 3)
                        {
                            currentWeek.MondaySelectionBg = Brushes.Blue;
                            currentWeek.MondaySelectionFg = Brushes.White;
                        }
                        else
						{
                            currentWeek.MondaySelectionBg = Brushes.Transparent;
                            currentWeek.MondaySelectionFg = Brushes.Black;
                        }

                        break;
                    case DaysOfTheWeek.Tuesday:
                        currentWeek.Tuesday = dayStr;

                        if (dayIfSelected.Priority == 1)
                        {
                            currentWeek.TuesdaySelectionBg = Brushes.Red;
                            currentWeek.TuesdaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 2)
                        {
                            currentWeek.TuesdaySelectionBg = Brushes.Green;
                            currentWeek.TuesdaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 3)
                        {
                            currentWeek.TuesdaySelectionBg = Brushes.Blue;
                            currentWeek.TuesdaySelectionFg = Brushes.White;
                        }
                        else
                        {
                            currentWeek.TuesdaySelectionBg = Brushes.Transparent;
                            currentWeek.TuesdaySelectionFg = Brushes.Black;
                        }

                        break;
                    case DaysOfTheWeek.Wednesday:
                        currentWeek.Wednesday = dayStr;

                        if (dayIfSelected.Priority == 1)
                        {
                            currentWeek.WednesdaySelectionBg = Brushes.Red;
                            currentWeek.WednesdaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 2)
                        {
                            currentWeek.WednesdaySelectionBg = Brushes.Green;
                            currentWeek.WednesdaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 3)
                        {
                            currentWeek.WednesdaySelectionBg = Brushes.Blue;
                            currentWeek.WednesdaySelectionFg = Brushes.White;
                        }
                        else
                        {
                            currentWeek.WednesdaySelectionBg = Brushes.Transparent;
                            currentWeek.WednesdaySelectionFg = Brushes.Black;
                        }

                        break;
                    case DaysOfTheWeek.Thursday:
                        currentWeek.Thursday = dayStr;

                        if (dayIfSelected.Priority == 1)
                        {
                            currentWeek.ThursdaySelectionBg = Brushes.Red;
                            currentWeek.ThursdaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 2)
                        {
                            currentWeek.ThursdaySelectionBg = Brushes.Green;
                            currentWeek.ThursdaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 3)
                        {
                            currentWeek.ThursdaySelectionBg = Brushes.Blue;
                            currentWeek.ThursdaySelectionFg = Brushes.White;
                        }
                        else
                        {
                            currentWeek.ThursdaySelectionBg = Brushes.Transparent;
                            currentWeek.ThursdaySelectionFg = Brushes.Black;
                        }

                        break;
                    case DaysOfTheWeek.Friday:
                        currentWeek.Friday = dayStr;

                        if (dayIfSelected.Priority == 1)
                        {
                            currentWeek.FridaySelectionBg = Brushes.Red;
                            currentWeek.FridaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 2)
                        {
                            currentWeek.FridaySelectionBg = Brushes.Green;
                            currentWeek.FridaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 3)
                        {
                            currentWeek.FridaySelectionBg = Brushes.Blue;
                            currentWeek.FridaySelectionFg = Brushes.White;
                        }
                        else
                        {
                            currentWeek.FridaySelectionBg = Brushes.Transparent;
                            currentWeek.FridaySelectionFg = Brushes.Black;
                        }

                        break;
                    case DaysOfTheWeek.Saturday:
                        currentWeek.Saturday = dayStr;

                        if (dayIfSelected.Priority == 1)
                        {
                            currentWeek.SaturdaySelectionBg = Brushes.Red;
                            currentWeek.SaturdaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 2)
                        {
                            currentWeek.SaturdaySelectionBg = Brushes.Green;
                            currentWeek.SaturdaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 3)
                        {
                            currentWeek.SaturdaySelectionBg = Brushes.Blue;
                            currentWeek.SaturdaySelectionFg = Brushes.White;
                        }
                        else
                        {
                            currentWeek.SaturdaySelectionBg = Brushes.Transparent;
                            currentWeek.SaturdaySelectionFg = Brushes.Black;
                        }

                        break;
                    case DaysOfTheWeek.Sunday:
                        currentWeek.Sunday = dayStr;

                        if (dayIfSelected.Priority == 1)
                        {
                            currentWeek.SundaySelectionBg = Brushes.Red;
                            currentWeek.SundaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 2)
                        {
                            currentWeek.SundaySelectionBg = Brushes.Green;
                            currentWeek.SundaySelectionFg = Brushes.White;
                        }
                        else if (dayIfSelected.Priority == 3)
                        {
                            currentWeek.SundaySelectionBg = Brushes.Blue;
                            currentWeek.SundaySelectionFg = Brushes.White;
                        }
                        else
                        {
                            currentWeek.SundaySelectionBg = Brushes.Transparent;
                            currentWeek.SundaySelectionFg = Brushes.Black;
                        }

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

        private void SaveCalendar()
		{
            TextWriter tw = new StreamWriter("calendar.txt");

            tw.WriteLine(SelectedDays.Count);

			foreach (var selectedDay in SelectedDays)
			{
                tw.WriteLine(selectedDay.MonthName);
                tw.WriteLine(selectedDay.Number);
                tw.WriteLine(selectedDay.Priority);
			}

            tw.Close();
        }

        private void ButtonSelectDay_Click(object sender, RoutedEventArgs e)
		{
            var button = (Button)sender;

            if (button.Content.ToString().Length == 0)
            {
                return;
            }

            //MessageBox.Show($"{button.Content.ToString()} of {CurrentMonthName}");

            int priority = 0;

            if (button.Background == Brushes.Transparent)
			{
                button.Background = Brushes.Red;
                button.Foreground = Brushes.White;

                priority = 1;
            }
            else if (button.Background == Brushes.Red)
			{
                button.Background = Brushes.Green;
                button.Foreground = Brushes.White;

                priority = 2;
            }
            else if (button.Background == Brushes.Green)
            {
                button.Background = Brushes.Blue;
                button.Foreground = Brushes.White;

                priority = 3;
            }
            else if (button.Background == Brushes.Blue)
            {
                button.Background = Brushes.Transparent;
                button.Foreground = Brushes.Black;

                priority = 0;
            }

            var selectedDay = GetIfDaySelected(Convert.ToInt32(button.Content));

            if (selectedDay.Priority != -1)
			{
                selectedDay.Priority = priority;
			}
            else
			{
                SelectedDays.Add(new SelectedDay(Convert.ToInt32(button.Content), CurrentMonthName, priority));
            }

            SaveCalendar();
        }
	}
}
