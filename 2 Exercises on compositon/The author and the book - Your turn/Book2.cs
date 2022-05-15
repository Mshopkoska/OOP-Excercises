using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.The_author_and_the_book___Your_turn
{
    public class Book2
    {
        private string isbn;
        private string name;
        private Author2 author;
        private double price;
        private int qty;

        public Book2(string isbn, string name, Author2 author, double price)
        {
            this.isbn = isbn;
            this.name = name;
            this.author = author;
            this.price = price;
            this.qty = 0;
        }
        public Book2(string isbn, string name, Author2 author, double price, int qty)
        {
            this.isbn = isbn;
            this.name = name;
            this.author = author;
            this.price = price;
            this.qty = qty;
        }

        public string getIsbn() { return isbn; }
        public string getName() { return name; }
        public Author2 getAuthor() { return author; }
        public double getPrice() { return price; }
        public int getQty() { return qty; }
        public void setQty(int qty) { this.qty = qty; }
        public void setPrice(double price) { this.price = price; }

        public string getAuthorName()
        {
            return this.author.getName();
        }

        public override string ToString()
        {
            return String.Format("Book[name = {0}, {1}, price = {2}, qty = {3}", this.name, author.ToString(), this.price, this.qty);
        }
    }
}
