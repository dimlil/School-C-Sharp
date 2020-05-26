using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTime
{
    class Program
    {
        class Time
        {
            private int hour;
            private int minutes;
            public Time()
            {
                hour = 0;
                minutes = 0;
            }
            public Time(int h, int m)
            {
                hour = h;
                minutes = m;
                norma();
            }
            public void norma()
            {
                if (minutes > 60)
                {
                    hour = hour + minutes / 60;
                    minutes = minutes % 60;
                }
                if (hour >= 24)
                {
                    hour -= 24;
                }
            }
            public void AddMinutes(int m)
            {
                minutes += m;
            }
            public void AddHour(int h)
            {
                hour += h;
            }
            public void Print()
            {
                Console.WriteLine("{0}:{1}", hour, minutes);
            }
            public static Time operator +(Time t, Time t1)
            {
                int h, m;
                h = t.hour + t1.hour;
                m = t.minutes + t1.minutes;
                Time r = new Time(h, m);
                return r;
            }
        }
        static void Main(string[] args)
        {
            Time t1 = new Time(12, 67);
            t1.Print();
            Time t2 = new Time(11, 55);
            t2.Print();
            Time t3 = new Time();
            t3 = t1 + t2;
            t3.Print();
        }
    }
}