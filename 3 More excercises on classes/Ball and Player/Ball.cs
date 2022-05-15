using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._3_More_excercises_on_classes.Ball_and_Player
{
    public class Ball
    {
        private float x;
        private float y;
        private float z;

        public Ball(float x, float y, float z)
        {
            this.x = x; this.y = y; this.z = z;
        }

        public float getX() { return x; }
        public float getY() { return y; }
        public float getZ() { return z; }

        public void setXYZ(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }

        public override string ToString()
        {
            return String.Format("({0},{1},{2})", x,y,z);
        }
    }
}
