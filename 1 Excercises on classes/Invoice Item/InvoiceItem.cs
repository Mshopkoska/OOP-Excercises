using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises.Invoice_Item
{
    public class InvoiceItem
    {
        private string id;
        private string description;
        private int qty;
        private double unitPrice;

        public InvoiceItem(string id, string description, int qty, double unitPrice)
        {
            this.id = id;
            this.description = description;  
            this.qty = qty; 
            this.unitPrice = unitPrice;
        }

        public string getId() { return id; }
        public string getDescription() { return description; }
        public int getQty() { return qty; }
        public double getUnitPrice() { return unitPrice; }

        public void setQty(int qty) { this.qty = qty; }
        public void setUnitPrice(double unitPrice) { this.unitPrice = unitPrice; }

        public double getTotal()
        {
            return this.qty * this.unitPrice;
        }

        public override string ToString()
        {
            return String.Format("InvoiceItem[id={0}, desc= {1}, qty = {2}, unitPrice = {3}", id, description,qty,unitPrice);
        }
    }
}
