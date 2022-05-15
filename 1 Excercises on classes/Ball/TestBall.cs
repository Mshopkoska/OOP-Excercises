using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises.Ball
{
    public class TestBall
    {
        /*
        public static void Main()
        {
            // Test constructor and toString()
            Ball ball = new Ball(1.1f, 2.2f, 10, 3.3f, 4.4f);
            Console.WriteLine(ball);  // toString()

            // Test Setters and Getters
            ball.setX(80.0f);
            ball.setY(35.0f);
            ball.setRadius(5);
            ball.setXDelta(4.0f);
            ball.setYDelta(6.0f);
            Console.WriteLine(ball);  // toString()
            Console.WriteLine("x is: " + ball.getX());
            Console.WriteLine("y is: " + ball.getY());
            Console.WriteLine("radius is: " + ball.getRadius());
            Console.WriteLine("xDelta is: " + ball.getXDelta());
            Console.WriteLine("yDelta is: " + ball.getYDelta());

            // Bounce the ball within the boundary
            float xMin = 0.0f;
            float xMax = 100.0f;
            float yMin = 0.0f;
            float yMax = 50.0f;
            for (int i = 0; i < 15; i++)
            {
                ball.move();
                Console.WriteLine(ball);
                float xNew = ball.getX();
                float yNew = ball.getY();
                int radius = ball.getRadius();
                // Check boundary value to bounce back
                if ((xNew + radius) > xMax || (xNew - radius) < xMin)
                {
                    ball.reflectHorizontal();
                }
                if ((yNew + radius) > yMax || (yNew - radius) < yMin)
                {
                    ball.reflectVertical();
                }
            }
        }*/
    }
}
