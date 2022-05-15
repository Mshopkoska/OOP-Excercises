using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._6_Polymorphism__Abstract_Classes_and_Interfaces.Movable_Interface__Movable_Point_and_Movable_Circle
{
    public class MovablePoint : Movable
    {
        public int x;
        public int y;
        public int xSpeed;
        public int ySpeed;


        public MovablePoint(int x, int y, int xSpeed, int ySpeed)
        {
            this.x = x; this.y = y; this.xSpeed = xSpeed; this.ySpeed = ySpeed;
        }

        public void moveDown()
        {
            y += ySpeed;
        }

        public void moveLeft()
        {
            x -= xSpeed;
        }

        public void moveRight()
        {
            x += xSpeed;
        }

        public void moveUp()
        {
            y -= ySpeed;
        }

        public override string ToString()
        {
            return String.Format("({0},{1}) speed= ({2},{3})", x, y, xSpeed, ySpeed);
        }
    }
}
