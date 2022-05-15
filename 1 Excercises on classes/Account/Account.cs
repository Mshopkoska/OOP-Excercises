using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises.Account
{
    public class Account
    {
        private string id;
        private string name;
        private int balance;

        public Account(string id, string name)
        {
            this.id = id;
            this.name = name;   
            this.balance = 0;
        }

        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        public string getId() { return id; }

        public string getName() { return name; }    
        public int getBalance() { return balance; } 

        public int credit(int amount)
        {
            int newBalance = balance + amount;
            this.balance = newBalance;

            return this.balance;
        }

        public int debit(int amount)
        {
            if (amount <= balance)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Amount exceeded balance");
            }
            return this.balance;
        }

        public int trasferTo(Account another, int amount)
        {
            if (amount <= this.balance)
            {
                another.balance += amount;
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Amount exceeded balance");
            }
            return this.balance;
        }

        public override string ToString()
        {
            return String.Format("Account[id={0}, name={1}, balance= {2}]", id, name, balance);
        }


    }
}
