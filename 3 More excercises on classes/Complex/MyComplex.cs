using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._3_More_excercises_on_classes
{
    public class MyComplex
    {
        private double real;
        private double imag;

        public MyComplex()
        {
            this.real = 0.0;
            this.imag = 0.0;
        }

        public MyComplex(double real, double imag)
        {
            this.real = real;
            this.imag = imag;
        }

        public double getImag() { return imag; }

        public double getReal() { return real; }

        public void setReal(double real) { this.real = real; }

        public void setImag(double imag) { this.imag = imag; }

        public void setValue(double real, double imag) { this.real = real; this.imag = imag; }

        public override string ToString()
        {
            return String.Format("{0}+{1}i", real, imag);
        }

        public Boolean isReal()
        {
            if (imag == 0) return true;
            return false;
        }
        public Boolean isImaginary()
        {
            if (real == 0) return true;
            return false;
        }

        public Boolean equals(double real, double imag)
        {
            if (this.real == real && this.imag == imag) return true;
            else return false;
        }

        public Boolean equals(MyComplex another)
        {
            if (this.real == another.real && this.imag == another.imag) return true;
            else return false;
        }


        public double magnitude()
        {
            return Math.Sqrt(real * real + imag * imag);
        }

        public MyComplex addInto(MyComplex right)
        {
            this.real += right.real;
            this.imag += right.imag;
            return this;
        }

        


        public double argument()
        {
            return Math.Atan2(imag, real);
        }

        public MyComplex add(MyComplex right)
        {
            this.real += right.real;
            this.imag += right.imag;

            return this;
        }

        public MyComplex addNew(MyComplex right)
        {
            return new MyComplex(this.real + right.real, this.imag + right.imag);
        }

        public MyComplex substract(MyComplex right)
        {
            this.real -= right.real;
            this.imag -= right.imag;

            return this;
        }

        public MyComplex substractNew(MyComplex right)
        {
            return new MyComplex(this.real - right.real, this.imag - right.imag);
        }

        public MyComplex multiply(MyComplex right)
        {
            this.real *= right.real;
            this.imag *= right.imag;

            return this;
        }
        public MyComplex multiplytNew(MyComplex right)
        {
            return new MyComplex(this.real * right.real, this.imag * right.imag);
        }

        public MyComplex divide(MyComplex right)
        {
            this.real /= right.real;
            this.imag /= right.imag;

            return this;
        }

        public MyComplex divideNew(MyComplex right)
        {
            return new MyComplex(this.real / right.real, this.imag / right.imag);
        }


        public MyComplex conjugate()
        {
            this.imag = this.imag * (-1);

            return this;
        }
    }
}
