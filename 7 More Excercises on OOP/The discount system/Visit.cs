using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._7_More_Excercises_on_OOP.The_discount_system
{
    public class Visit
    {
        private Customer customer;
        private DateTime date;
        private double serviceExpense;
        private double productExpense;

        public Visit(string name, DateTime date)
        {
            this.customer = new Customer(name);
            this.date = date;
        }

        public string getName() { return customer.getName(); }

        public double getServiceExpense() { return serviceExpense; }    
        public double getProductExpense() { return productExpense; }
        public void setServiceExpense(double serviceExpense) { this.serviceExpense = serviceExpense; }
        public void setProductExpense(double productExpense) { this.productExpense = productExpense; }

        public double getTotalExpense() { return serviceExpense+ productExpense; }


    }
}
