using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._3_More_excercises_on_classes.MyTime
{
    public class MyTime
    {
        private int hour;
        private int minute;
        private int second;

        public MyTime()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }

        public MyTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void setTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second=second;
        }
        public int getHour() { return hour; }
        public int getMinute() { return minute; }
        public int getSecond() { return second; }
        public void setHour(int hour) { this.hour = hour; }
        public void setMinute(int minute) { this.minute = minute; }
        public void setSecond(int second) { this.second = second; }

        public override string ToString()
        {
            string h = "";
            string m = "";
            string s = "";
            if (hour >= 0 && hour <= 9) h = 0 + hour.ToString();
            else h = hour.ToString();
            
            if (minute >= 0 && minute <= 9) m = 0 + minute.ToString();
            else m = minute.ToString();
           
            if (second >= 0 && second <= 9) s = 0 + second.ToString();
            else s = s.ToString();

            return String.Format("{0}:{1}:{2}", h, m, s);
        }

        public MyTime nextSecond()
        {
            if(this.hour == 23 && this.minute==59 && this.second== 59)
            {
                this.hour = 0;
                this.minute = 0;
                this.second = 0;
            }
            else if(this.second == 59 && this.minute == 59)
            {
                this.hour += 1;
                this.minute = 0;
                this.second = 0;
            }
            else if (this.second == 59)
            {
                this.minute += 1;
                this.second = 0;
            }
            else
            {
                this.second += 1;
            }
            return this;
        }

        public MyTime previousSecond()
        {
            if (this.hour == 00 && this.minute == 00 && this.second == 00)
            {
                this.hour = 23;
                this.minute = 59;
                this.second = 59;
            }
            else
            {
                this.second -= 1;
            }
            return this;
        }

        public MyTime nextMinute()
        {
            if (this.hour == 23 && this.minute == 59)
            {
                this.hour = 0;
                this.minute = 0;
            }
            else if (minute == 59)
            {
                this.hour += 1;
                this.minute = 00;
            }
            else
            {
                this.minute += 1;
            }
            return this;
        }

        public MyTime previousMinute()
        {
            if (this.hour == 00 && this.minute == 00)
            {
                this.hour = 23;
                this.minute = 59;
            }
            else if (minute == 00)
            {
                this.hour -= 1;
                this.minute-= 59;
            }
            else
            {
                this.minute -= 1;
            }
            return this;
        }

        public MyTime nextHour()
        {
            if (this.hour == 23)
            {
                this.hour = 0;
            }
            else
            {
                this.hour += 1;
            }
            return this;
        }

        public MyTime previousHour()
        {
            if (this.hour == 00)
            {
                this.hour = 23;
            }
            else
            {
                this.hour -= 1;
            }
            return this;
        }
    }
}
