using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.The_customer_and_Invoice
{
    public class Invoice
    {
        private int id;
        private Customer customer;
        private double amount;

        public Invoice(int id, Customer customer, double amount)
        {
            this.id = id;
            this.customer = customer;
            this.amount = amount;
        }

        public int getId() { return id; }
        public Customer getCustomer() { return customer; }
        public void setCustomer(Customer customer) { this.customer = customer; }    
        public int getCustomerID() { return this.customer.getId(); }
        public string getCustomerName() { return this.customer.getName(); }

        public double getCustomerDiscount() { return this.customer.getDiscount(); }
        public double getAmount() { return amount; }
        public void setAmount(double amount) { this.amount = amount; }

        public double getAmountAfterDiscount()
        {
            double discount = this.amount * this.customer.getDiscount() / 100;
            return amount - discount;
        }

        public override string ToString()
        {
            return String.Format("Invoice[id = {0}, customer ={1}, amount = {2:0.0}]", id, customer.ToString(), this.amount);
        }


    }
}
