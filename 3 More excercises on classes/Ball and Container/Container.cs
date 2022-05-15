using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._3_More_excercises_on_classes.Ball_and_Container
{
    public class Container
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;

        public Container(int x, int y, int width, int height)
        {
            this.x1 = x;
            this.y1 = y;

            this.x2 = x + width - 1;  //width=x2-x1+1
            this.y2 = y + height -1;  //height= x2-x1+1
        }

        public int getX()
        {
            return x2 - x1; 
        }

        public int getY()
        {
            return y2 - y1;
        }

        public int getWidth()
        {
            return x2 - x1 + 1;
        }

        public int getHeight()
        {
            return x2 - x1 + 1;
        }

        public override string ToString()
        {
            return String.Format("Container[({0},{1}),({2},{3})", x1,y1,x2,y2);
        }


    }
}
