using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.The_Customer_and_Account
{
    public class Account
    {
        private int id;
        private Customer customer;
        private double balance;

        public Account(int id, Customer customer, double balance)
        {
            this.id = id;
            this.customer = customer;
            this.balance = balance;
        }

        public Account(int id, Customer customer) { this.id = id; this.customer = customer; this.balance = 0.0; }

        public int getId() { return id; }
        public Customer getCustomer() { return customer; }
        public double getBalance() { return balance; }
        public void setBalance(double balance) { this.balance = balance; }

        public string getCustomerName()
        {
            return customer.getName();
        }

        public override string ToString()
        {
            return string.Format("{0} balance = ${1:0.00}", this.customer.ToString(), balance);
        }

        public Account deposit(double amount)
        {
            return new Account(this.id, this.customer, balance + amount);
        }

        public Account withdraw(double amount)
        {
            if(amount<=balance) return new Account(this.id, this.customer, balance - amount);
            else
            {
                Console.WriteLine("Amount withdrawn exceedes the current balance!");
                return this;
            }
        }
    }
}
