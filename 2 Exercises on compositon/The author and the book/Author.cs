using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._2_Exercises_on_compositon.The_author_and_the_book
{
    public class Author
    {
        private string name;
        private string email;
        private char gender;

        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }

        public string getName() { return name; }
        public string getEmail() { return email; }
        public char getGender() { return gender; }
        public void setEmail(string email) { this.email = email; }

        public override string ToString()
        {
            return String.Format("Author[name={0}, email={1}, gender= {2}]", name, email, gender);
        }

    }

}