using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowTime
{
    class NowTime
    {
        public int hours = 0;
        public int minutes = 0;
        public int seconds = 0;

        public NowTime(int hours, int minutes, int seconds)
        {
            if (hours >= 0 && hours <= 23)
            {
                this.hours = hours;
            }
            else
            {
                this.hours = 0;
            }
            if (minutes >= 0 && minutes <= 59)
            {
                this.minutes = minutes;
            }
            else
            {
                this.minutes = 0;
            }
            if (seconds >= 0 && seconds <= 59)
            {
                this.seconds = seconds;
            }
            else
            {
                this.seconds = 0;
            }
        }
        public NowTime() { }
        public void TimeNow()
        {
            Console.WriteLine($"Time: {hours}:{minutes}:{seconds}\n----------\n");
        }

        public void ChangeTime(int hours, int minutes,int seconds)
        {
            if (hours >= 0 && hours <= 23)
            {
                this.hours = hours;
            }
            else
            {
                this.hours = 0;
            }
            if (minutes >= 0 && minutes <= 59)
            {
                this.minutes = minutes;
            }
            else
            {
                this.minutes = 0;
            }
            if (seconds >= 0 && seconds <= 59)
            {
                this.seconds = seconds;
            }
            else
            {
                this.seconds = 0;
            }
        }
        public void ChangeHours(int hours)
        {
            if (hours >= 0 && hours <= 23)
            {
                this.hours = hours;
            }
            else
            {
                this.hours = 0;
            }
        }
        public void ChangeMinutes(int minutes)
        {
            if (minutes >= 0 && minutes <= 59)
            {
                this.minutes = minutes;
            }
            else
            {
                this.minutes = 0;
            }
        }
        public void ChangeSeconds(int seconds)
        {
            if (seconds >= 0 && seconds <= 59)
            {
                this.seconds = seconds;
            }
            else
            {
                this.seconds = 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Time right now: {System.DateTime.Now}");
            NowTime nt = new NowTime();
            nt.ChangeTime(23, 50, 12);
            nt.TimeNow();
            nt.ChangeHours(12);
            nt.TimeNow();
            nt.ChangeMinutes(73);//больше 60
            nt.TimeNow();
            nt.ChangeSeconds(10);
            nt.TimeNow();
            Console.ReadKey();
        }
    }
}
