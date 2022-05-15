using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises.Time
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public int getHour() { return hour; }
        public int getMinute() { return minute; }
        public int getSecond() { return second; }

        public void setHour(int hour) { this.hour = hour; }
        public void setMinute(int minute) { this.minute = minute; }
        public void setSecond(int second) { this.second = second; }

        public void setTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public override string ToString()
        {
            string hour = "";
            string minute = "";
            string second = "";

            if (this.hour >= 0 && this.hour <= 9)
            {
                hour = 0 + this.hour.ToString();
            }
            else
            {
                hour = this.hour.ToString();
            }

            if (this.minute >= 0 && this.minute <= 9)
            {
                minute = 0 + this.minute.ToString();
            }
            else
            {
                minute = this.minute.ToString();
            }

            if (this.second >= 0 && this.second <= 9)
            {
                second = 0 + this.second.ToString();
            }
            else
            {
                second = this.second.ToString();
            }

            return String.Format("{0}:{1}:{2}", hour, minute, second);
        }

        public Time nextSecond()
        {
            if (hour == 23 && minute == 59 && second == 59)
            {
                /*this.hour = 0;
                this.minute = 0;
                this.second = 1;*/
                return new Time(0, 0, 1);
            }
            else if (second == 59 && minute == 59)
            {
                /*this.hour++;
                this.minute = 0;
                this.second = 0;*/

                return new Time(this.hour+1, 0, 0);
            }
            else
            {
                return new Time(this.hour, this.minute, this.second+1);
                
            }
        }

        public Time previousSecond()
        {
           
            if (hour == 00 && minute == 00 && second == 00)
            {
               
                return new Time(23, 59, 59);
            }
            else
            {
                return new Time(this.hour, this.minute, this.second-1);
            }
        }

    }
}
