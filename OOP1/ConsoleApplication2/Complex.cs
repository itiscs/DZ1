using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Complex
    {

        private double re;
        private double im;

        public double Module
        {
            get { return Math.Sqrt(re * re + im * im); }
        }

        public double Arg
        {
            get { return Math.Acos(re/Module); }
        }

        public double Re
        {
            get
            {
                return re;
            }

            set
            {
                re = value;
            }
        }

        public double Im
        {
            get
            {
                return im;
            }

            set
            {
                im = value;
            }
        }
        
        public Complex(double r, double i)
        {
            this.Re = r;
            this.Im = i;
        }

        public Complex(double r):this(r,0)
        {
        }
        public Complex() : this(0, 0)
        {
        }

        public static Complex CreateFromTrigonom(double mod, double arg)
        {
            Complex c = new Complex();
            c.re = mod * Math.Cos(arg);
            c.im = mod * Math.Sin(arg);
            return c;
        }

        public void Sum(Complex c1, Complex c2)
        {
            //Complex c3 = new Complex();
            re = c1.Re + c2.Re;
            im = c1.Im + c2.Im;
            //return c3;
        }

        public static Complex SumStatic(Complex c1, Complex c2)
        {
            Complex c3 = new Complex();
            c3.re = c1.Re + c2.Re;
            c3.im = c1.Im + c2.Im;
            return c3;
        }

        public static Complex operator+(Complex c1, Complex c2)
        {
            Complex c3 = new Complex();
            c3.re = c1.Re + c2.Re;
            c3.im = c1.Im + c2.Im;
            return c3;
        }

        public void Mult(Complex c1, Complex c2)
        {
            re = c1.Re * c2.Re - c1.Im * c2.Im;
            im = c1.Re * c2.Im + c2.Re * c1.Im;
            
        }

        public static Complex MultStatic(Complex c1, Complex c2)
        {
            return new Complex(c1.Re * c2.Re - c1.Im * c2.Im, c1.Re * c2.Im + c2.Re * c1.Im);
        }

        public static Complex operator*(Complex c1, Complex c2)
        {   
            return new Complex(c1.Re * c2.Re - c1.Im * c2.Im, c1.Re * c2.Im + c2.Re * c1.Im);
        }
        


        public override string ToString()
        {
            return String.Format($"{re}+{im}i");
        }
















    }
}
