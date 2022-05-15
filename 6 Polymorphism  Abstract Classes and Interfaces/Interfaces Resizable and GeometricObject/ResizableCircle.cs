using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._6_Polymorphism__Abstract_Classes_and_Interfaces.Interfaces_Resizable_and_GeometricObject
{
    public class ResizableCircle : Circle, Resizable
    {
        public ResizableCircle(double radius) : base(radius)
        {
        }

        public void resize(int percentage)
        {
            radius *= percentage / 100.0;
        }

        public override string ToString()
        {
            return String.Format("ResizableCircle[{0}]", base.ToString());
        }
    }
}
