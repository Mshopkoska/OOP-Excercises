using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Person_Staff_and_Student
{
    public class Student : Person
    {
        string program;
        int year;
        double fee;

        Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.program = program;
            this.year = year;
        }

        public string getProgram() { return program; }
        public void setProgram(string program) { this.program = program; }
        public int getYear() { return year; }
        public void setYear(int year) { this.year = year; }
        public double getFee() { return fee; }
        public void setFee(double fee) { this.fee = fee; }

        public override string ToString()
        {
            return string.Format("Student[{0}, program = {1}, year = {2}, fee = {3}]");
        }

    }
}
