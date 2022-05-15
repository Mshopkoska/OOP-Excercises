using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Person_Staff_and_Student
{
    public class Staff : Person
    {
        string school;
        double pay;

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.school= school;
            this.pay= pay;
        }

        public string getSchool() { return school; }
        public double getPay() { return pay; }
        public void setPay(double pay) { this.pay = pay; }
        public void setName(string name) { this.name = name; }

        public override string ToString()
        {
            return String.Format("Staff[{0},school = {1}, pay = {2}]",base.ToString(),school,pay);
        }


    }
}
