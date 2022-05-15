using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises.Date
{
    public class Date
    {
        private int day;
        private int month;
        private int year;   

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int getDay() { return day; }
        public int getMonth() { return month; }
        public int getYear() { return year; }
        public void setDay(int day) { this.day = day; }
        public void setMonth(int month) { this.month = month; }
        public void setYear(int year) { this.year = year; }

        public void setDate(int day, int month, int year)
        {
            this.day = day;
            this.month=month;   
            this.year= year;    
        }

        public override string ToString()
        {
            string day = "";
            string month = "";
            if(this.day>=0 && this.day<=9)
            {
                day = 0 + this.day.ToString();
            }
            else
            {
                day = this.day.ToString();
            }
            if(this.month >= 0 && this.month <= 9)
            {
                month = 0 + this.month.ToString();
            }
            else
            {
                month = this.month.ToString();
            }

            return String.Format("{0}/{1}/{2}", day, month, year);
        }
    }
}
