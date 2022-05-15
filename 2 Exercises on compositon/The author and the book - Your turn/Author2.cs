using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.The_author_and_the_book___Your_turn
{
    public class Author2
    {
        private string name;
        private string email;

        public Author2(string name, string email)
        {
            this.name = name;   
            this.email = email;
        }
        public string getName() { return name; }
        public string getEmail() { return email; }

        public void setName(string name) { this.name = name; }
        public void setEmail(string email) { this.email = email; }

        public override string ToString()
        {
            return String.Format("Author[name = {0}, email = {1}]", name,email);
        }
    }
}
