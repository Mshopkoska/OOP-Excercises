using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Point2D_and_Point3D
{
    public class Point3D : Point2D
    {
        float z;

        Point3D()
        {
            z = 0.0f;
        }

        Point3D(float x, float y, float z) : base(x,y)
        {
            this.z = z;
        }

        public float getZ() { return z; }
        public void setZ(float z) { this.z = z; }

        public void setXYZ(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;   
        }

        public float[] getXYZ()
        {
            return new float[] { x, y, z };
        }

        public override string ToString()
        {
            return string.Format("({0},{1},{2})", x, y, z);
        }


    }
}
