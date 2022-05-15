using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._6_Polymorphism__Abstract_Classes_and_Interfaces.Interface_movable_and_subclasses
{
    public class MovableRectangle : Movable
    {

        private MovablePoint topLeft;
        private MovablePoint bottomRight;

        public MovableRectangle(int x1, int y1, int x2, int y2, int xSpeed, int ySpeed)
        {
            topLeft.x= x1;
            topLeft.y= y1;
            topLeft.xSpeed= xSpeed;
            topLeft.ySpeed= ySpeed;

            bottomRight.x= x2;
            bottomRight.y= y2;
            bottomRight.xSpeed= xSpeed;
            bottomRight.ySpeed= ySpeed;

        }

        public void moveDown()
        {
            topLeft.y += topLeft.ySpeed;
            bottomRight.y+=bottomRight.ySpeed;
        }

        public void moveLeft()
        {
            topLeft.x -= topLeft.xSpeed;
            bottomRight.x -= bottomRight.xSpeed;
        }

        public void moveRight()
        {
            topLeft.x += topLeft.xSpeed;
            bottomRight.x += bottomRight.xSpeed;
        }

        public void moveUp()
        {
            topLeft.y -= topLeft.ySpeed;
            bottomRight.y -= bottomRight.ySpeed;
        }
    }
}
