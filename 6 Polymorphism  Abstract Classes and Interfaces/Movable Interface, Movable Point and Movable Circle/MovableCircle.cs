using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._6_Polymorphism__Abstract_Classes_and_Interfaces.Movable_Interface__Movable_Point_and_Movable_Circle
{
    internal class MovableCircle : Movable
    {
        int radius;
        MovablePoint center;

        public MovableCircle(int x, int y, int xSpeed, int ySpeed, int radius)
        {
            center.x = x;
            center.y = y;
            center.xSpeed = xSpeed;
            center.ySpeed = ySpeed;
            this.radius = radius;
        }

        public override string ToString()
        {
            return String.Format("{0}, radius = {1}", center.ToString(), radius);
        }
        public void moveDown()
        {
            center.y += center.ySpeed;
        }

        public void moveLeft()
        {
            center.x -= center.xSpeed;
        }

        public void moveRight()
        {
            center.x += center.xSpeed;
        }

        public void moveUp()
        {
            center.y -= center.ySpeed;
        }
    }
}
