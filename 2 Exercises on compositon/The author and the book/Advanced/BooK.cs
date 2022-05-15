using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.The_author_and_the_book.Advanced
{
    public class BooK
    {
        private string name;
        private Author[] authors;
        private double price;
        private int qty;

        public BooK(string name, Author[] authors, double price)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = 0;
        }

        public BooK(string name, Author[] authors, double price, int qty)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = qty;
        }

        public string getName() { return name; }
        public Author[] getAuthors() { return authors; }
        public double getPrice() { return price; }
        public void setPrice(double price) { this.price = price; }
        public int getQty() { return qty; }
        public void setQty(int qty) { this.qty = qty; }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            foreach(Author a in authors)
            {
                st.Append(a.ToString() + ",");
            }
            st.Length--;
            string result = st.ToString();
            return String.Format("Book[name = {0}, authors ={1}, price = {2}, qty = {3}]", this.name, result, this.price, this.qty);
        }

        public String getAuthorNames()
        {
            StringBuilder st = new StringBuilder();
            foreach (Author a in authors)
            {
                st.Append(a.getName + ",");
            }
            st.Length--;

            return st.ToString();
        }
    }
}
