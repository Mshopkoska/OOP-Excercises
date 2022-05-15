using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.The_Customer_and_Account
{
    public class Customer
    {
        private int id;
        private string name;
        private char gender;
        private int discount;


        Customer(int id, string name, int discount)
        {
            this.id = id;
            this.name = name;   
            this.discount = discount;
        }
        public int getId() { return id; }
        public string getName() { return name; }
        public char getGender() { return gender; }

        public override string ToString()
        {
            return string.Format("{0}({1})", name, id);
        }
    }
}
