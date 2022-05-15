using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises.Employee
{
    public class Employee
    {
        private int Id;
        private string FirstName;

        private string LastName;

        private int Salary;



        public Employee(int id, string firstName, string lastName, int salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }


        public int getId() { return this.Id; }

        public string getFirstName() { return this.FirstName; }
        public string getLastName() { return this.LastName; }
        public string getName() { return this.FirstName + " " + this.LastName; }
        public int getSalary() { return this.Salary; }
        public void setSalary(int salary) { this.Salary = salary; }

        public int getAnnualSalary() { return this.Salary * 12; }

        public int raiseSalary(int percentage)
        {
            int newSalary = Salary + (Salary * percentage / 100);
            return newSalary;
        }

        public override string ToString()
        {
            return String.Format("Employee[id = {0}, name = {1} {2}, salary = {3}]", this.Id, this.FirstName, this.LastName, this.Salary);
        }

    }
}
