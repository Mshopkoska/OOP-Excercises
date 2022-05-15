using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._3_More_excercises_on_classes.Polynomial
{
    public class MyPolynomial
    {
        private double[] coeffs;

        public MyPolynomial(double[] coeffs) { this.coeffs = coeffs; }
        

        public int getDegree()
        {
            return coeffs.Count()-1;   
        }

        public override string ToString()
        {
            int degree = getDegree();
            StringBuilder sb = new StringBuilder();
            foreach(double c in coeffs)
            {
                sb.Append(String.Format("{0}x^{1} + ", c, degree));
                degree--; 
            }
            sb.Length--;
            return sb.ToString();
        }

        public double evaluate(double x)
        {
            double result = 0.0;
            int degree = getDegree();

            foreach (double c in coeffs)
            {
                result += c * Math.Pow(x, degree);
                degree--;
            }
            return result;
        }

        public MyPolynomial add(MyPolynomial right)
        {
            double[] result = new double[right.coeffs.Length];

            for(int i =0; i < right.coeffs.Length; i++)
            {
                result[i]= this.coeffs[i] + right.coeffs[i];
            }
            return new MyPolynomial(result);
        }

        public MyPolynomial multiply(MyPolynomial right)
        {
            double[] result = new double[right.coeffs.Length];

            for (int i = 0; i < right.coeffs.Length; i++)
            {
                result[i] = this.coeffs[i] * right.coeffs[i];
            }
            return new MyPolynomial(result);
        }
    }
}
