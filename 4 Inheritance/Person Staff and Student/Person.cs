using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Person_Staff_and_Student
{
    public class Person
    {
        protected string name;
        protected string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string getName() { return name; }
        public string getAddress() { return address; }
        public void setAddress(string address) { this.address = address; }

        public override string ToString()
        {
            return string.Format("Person[name = {0}, address = {1}]", name, address);
        }

    }
}
