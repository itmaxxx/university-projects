using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public enum DaysOfTheWeek
    {
        Monday, 
        Tuesday, 
        Wednesday, 
        Thursday, 
        Friday, 
        Saturday, 
        Sunday
    }

    public enum MonthsNames
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        Septemeber,
        October,
        November,
        December
    };

    public class Day
    {
        public int Number { get; set; }
        public DaysOfTheWeek DayOfTheWeek { get; set; }

        public static int GetMonthDaysCount(MonthsNames month)
        {
            switch (month)
            {
                case MonthsNames.January:
                    return 31;
                case MonthsNames.February:
                    return 28;
                case MonthsNames.March:
                    return 31;
                case MonthsNames.April:
                    return 30;
                case MonthsNames.May:
                    return 31;
                case MonthsNames.June:
                    return 30;
                case MonthsNames.July:
                    return 31;
                case MonthsNames.August:
                    return 31;
                case MonthsNames.Septemeber:
                    return 30;
                case MonthsNames.October:
                    return 31;
                case MonthsNames.November:
                    return 30;
                case MonthsNames.December:
                    return 31;
                default: throw new Exception("Month doesn't exist");
            }
        }
    }

    public class Week
    {
        public string Monday { get; set; } = string.Empty;
        public string Tuesday { get; set; } = string.Empty;
        public string Wednesday { get; set; } = string.Empty;
        public string Thursday { get; set; } = string.Empty;
        public string Friday { get; set; } = string.Empty;
        public string Saturday { get; set; } = string.Empty;
        public string Sunday { get; set; } = string.Empty;
    }

    public class Month
    {
        public List<Day> Days { get; set; }
        public MonthsNames Name { get; set; }
    }

    public class Year
    {
        public List<Month> Months { get; private set; }

        public Year()
        {
            CreateCalendar();
        }

        private void CreateCalendar()
        {
            Months = new List<Month>(12);

            int currentDayOfTheWeek = 0;

            for (int currMonth = 0; currMonth < 12; currMonth++)
            {
				var month = new Month
				{
					Name = (MonthsNames)currMonth
                };

				int DaysInMonth = Day.GetMonthDaysCount((MonthsNames)currMonth);

                month.Days = new List<Day>(DaysInMonth);

                for (int currDay = 1; currDay <= month.Days.Capacity; currDay++)
                {
					var day = new Day
					{
						Number = currDay,
						DayOfTheWeek = (DaysOfTheWeek)currentDayOfTheWeek
                    };

                    currentDayOfTheWeek++;

                    // New week
                    if (currentDayOfTheWeek > 6)
					{
                        currentDayOfTheWeek = 0;
                    }

                    month.Days.Add(day);
                }

                Months.Add(month);
            }

            Months.AddRange(Months);
        }
    }
}
