using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 4), c2 = new Complex(-3,-5);

            Complex c = Complex.CreateFromTrigonom(5, 1.4);
            Console.WriteLine(c);

            //c3 = c1 + c2
            //c4 = c1 * c2

            //Complex c3 = new Complex();
            //c3.Sum(c1, c2);
            //Complex c3 = Complex.SumStatic(c1, c2);
            Complex c3 = c1 + c2;
            Console.WriteLine($"{c1} + {c2} = {c3}");

            //Complex c4 = new Complex(c1.Re * c2.Re - c1.Im * c2.Im, c1.Re * c2.Im + c2.Re * c1.Im);
            //Complex c4 = new Complex();
            //c4.Mult(c1, c2);
            //Complex c4 = Complex.MultStatic(c1, c2);
            Complex c4 = c1 * c2;
            Console.WriteLine($"{c1} * {c2} = {c4}");




            //Point p = new Point(6,2);
            //Point p1 = new Point();

            ////p.SetX(5);
            ////p.SetY(3);

            //p.SetX(p.GetX() - 3);

            ////Console.WriteLine($"Point - ({p.GetX()},{p.GetY()})");
            //Console.WriteLine(p);
            //Console.WriteLine(p1);
            //Console.WriteLine($"Расстояние от точки 1 - {p.Module()}");
            //Console.WriteLine($"Расстояние от точки 2 - {p1.Module()}");


        }
    }
}
