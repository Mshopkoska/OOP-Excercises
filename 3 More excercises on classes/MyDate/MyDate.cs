using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._3_More_excercises_on_classes.MyDate
{
    public class MyDate
    {
        private int year;
        private int month;
        private int day;

        private string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        private int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


        public MyDate(int year, int month, int day)
        {
            this.year=year;
            this.month=month;
            this.day=day;

        }

        public void setDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;

        }

        public int getYear() { return year; }
        public int getMonth() { return month; }
        public int getDay() { return day; }
        public void setYear(int year) { this.year = year; }
        public void setMonth(int month) { this.month = month; }
        public void setDay(int day) { this.day = day; }

        public override string ToString()
        {
            string d = "";
            if (day == 0) d = "Sunday";
            if (day == 1) d = "Monday";
            if (day == 2) d = "Tuesday";
            if (day == 3) d = "Wednesday";
            if (day == 4) d = "Thursday";
            if (day == 5) d = "Friday";
            if (day == 6) d = "Saturday";

            return string.Format("{0} {1} {2} {3}", d, day, month, year);
        }

        public Boolean isLeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) return true;
            else return false;
        }

        public Boolean isValidDate(int year, int month, int day)
        {
            if (!(year <= 9999 && year >= 1)) return false;
            if (!(month == 1 && day == 31)) return false;
            if (!((month == 2 && isLeapYear(year) && day == 29) || (month == 2 && !isLeapYear(year) && day == 28))) return false;
            if (!(month == 3 && day == 31)) return false;
            if (!(month == 4 && day == 30)) return false;
            if (!(month == 5 && day == 31)) return false;
            if (!(month == 6 && day == 30)) return false;
            if (!(month == 7 && day == 31)) return false;
            if (!(month == 8 && day == 31)) return false;
            if (!(month == 9 && day == 30)) return false;
            if (!(month == 10 && day == 31)) return false;
            if (!(month == 11 && day == 30)) return false;
            if (!(month == 12 && day == 31)) return false;

            return true;
        }

        public int getDayOfWeek(int d, int m, int y)
        {
            int[] t = { 0, 3, 2, 5, 0, 3, 5,
                            1, 4, 6, 2, 4 };
            y -= (m < 3) ? 1 : 0;

            return (y + y / 4 - y / 100 + y / 400 + t[m - 1] + d) % 7;
        }

        public MyDate nextDay()
        { 
            //ako e 31 januari nareden den e  nova godina
            if(month == 12 && day ==31)
            {
                this.day = 0;
                this.month = 1;
                this.year += 1;
            } 
            // ako e kraj na mesec sto ima 31 dena
            else if(day == 31 && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10))
            {
                this.day = 0;
                this.month += 1;
            }
            else if (day == 30 && (month == 4 || month == 6 || month == 9 || month == 11))
            {
                this.day = 0;
                this.month += 1;
            }
            else if ((day == 29 && isLeapYear(year) && month == 2) || (day == 28 && !isLeapYear(year) && month == 2))
            {
                this.day = 0;
                this.month += 1;
            }
            else
            {
                this.day += 1;
            }
            return this;
        }
        public MyDate previousDay()
        {
            //ako e 1 januari prethoden den e 31dek
            if (month == 1 && day == 1)
            {
                this.day = 31;
                this.month = 12;
                this.year -= 1;
            }
            // ako e pochetok na mesec sto ima 31 dena iskluchok 3ti mesec zasto vrakja vo fevruari i januari stov rakja vo dekemvri
            else if (day == 1 && (month == 5 || month == 7 || month==10 || month == 12))
            {
                this.day = 31;
                this.month -= 1;
            }
            //Mart vo Fevruari koga vrakjame
            else if(day == 1 && month == 30)
            {

            }


            else if (day == 30 && (month == 4 || month == 6 || month == 9 || month == 11))
            {
                this.day = 0;
                this.month += 1;
            }
            else if ((day == 29 && isLeapYear(year) && month == 2) || (day == 28 && !isLeapYear(year) && month == 2))
            {
                this.day = 0;
                this.month += 1;
            }
            else
            {
                this.day += 1;
            }
            return this;
        }


        public MyDate nextMonth()
        {
            if(month == 12)
            {
                this.month = 0;
                this.year += 1;
            }
            else
            {
                this.month += 1;
            }
            return this;
        }

        public MyDate nextYear()
        {
            this.year += 1;
            return this;
        }

        public MyDate previousYear()
        {
            this.year -= 1;
            return this;
        }

        public MyDate previousMonth()
        {
            if (month == 1)
            {
                this.month = 12;
                this.year -= 1;
            }
            else
            {
                this.month -= 1;
            }
            return this;
        }
    }
}
