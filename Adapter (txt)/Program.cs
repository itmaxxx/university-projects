using System;

namespace Adapter
{
    class ArrowClock
    {
        private int HoursArrow;
        private int MinutesArrow;
        private bool AnteMeridian;    // true = AM / false = PM
        
        public ArrowClock(int hours, int minutes, bool anteMeridian)
        {
            HoursArrow = hours;
            MinutesArrow = minutes;
            AnteMeridian = anteMeridian;

            if (hours >= 12 || hours <= 0) 
            {
                HoursArrow = 0;
                AnteMeridian = true;
            }

            if (minutes > 59  || minutes < 0)
            {
                MinutesArrow = 0;
            }
        }

        public void ShowTime() 
        {
            string AMPM = AnteMeridian ? "AM" : "PM";

            Console.WriteLine($"Arrow Clock Time : \n{HoursArrow} : {MinutesArrow} {AMPM}\n");
        }

        public int GetHourArrowValue() 
        { 
            return HoursArrow; 
        }
        
        public int GetMinuteArrowValue() 
        { 
            return MinutesArrow; 
        }

        public bool GetMeridiem() 
        { 
            return AnteMeridian; 
        }
    }

    abstract class DigitalClock 
    {
        public abstract void ShowTime();
    }

    class DigitalClockAdapter : DigitalClock
    {
        private ArrowClock arrowclock;

        public DigitalClockAdapter(ArrowClock clock) {
            arrowclock = clock;
        }

        public override void ShowTime() 
        {
            int hours = arrowclock.GetHourArrowValue();
            int minutes = arrowclock.GetMinuteArrowValue();
            bool anteMeridian = arrowclock.GetMeridiem();

            if (!anteMeridian) 
                hours = hours + 12;

            string AMPM = anteMeridian ? "AM" : "PM";
            
            Console.WriteLine($"Digital Clock Time :\n{hours} : {minutes} {AMPM}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DigitalClock clock = new DigitalClockAdapter(new ArrowClock(6, 45, false));
            clock.ShowTime();
        }
    }
}
