using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.The_customer_and_Invoice
{
    public class Customer
    {
        private int id;
        private string name;
        private int discount;

        public Customer(int id, string name, int discount)
        {
            this.id = id;
            this.name = name;
            this.discount = discount;
        }

        public int getId() { return id; }
        public string getName() { return name; }
        public int getDiscount() { return discount; }
        public void setDiscount(int discount) { this.discount = discount; }


        public override string ToString()
        {
            return string.Format("{0}({1})({2}%)", name, id, discount);
        }


    }
}
