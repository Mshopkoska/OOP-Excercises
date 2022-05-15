using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.The_author_and_the_book
{
    public class Book
    {
        private string name;
        private Author author;
        private double price;
        private int qty;

        public Book(string name, Author author, double price)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.qty = 0;
        }

        public Book(string name, Author author, double price, int qty)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.qty = qty;
        }

        public string getName() { return name; }
        public Author getAuthor() {return author; } 
        public double getPrice() { return price; } 
        public void setPrice(double price) { this.price = price; }
        public int getQty(){ return qty; } 
        public void setQty(int qty) { this.qty = qty; }

        public override string ToString()
        {
            return String.Format("Book[name = {0}, {1}, price = {2}, qty = {3}", this.name, author.ToString(), this.price, this.qty);
        }




    }
}
