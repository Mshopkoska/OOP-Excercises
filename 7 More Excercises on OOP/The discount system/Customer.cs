using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._7_More_Excercises_on_OOP.The_discount_system
{
    public class Customer
    {
        protected string name;
        protected bool member;
        protected string memberType;

        public Customer(string name)
        {
            this.name = name;
        }

        public string getName() { return name; }
        public bool IsMember() { return member; }
        public string getMemberType() { return memberType; }
        public void setMemberType(string type) { memberType = type; }
        public void setMember(bool member) { this.member = member; }

        public override string ToString()
        {
            return name;
        }

    }
}
