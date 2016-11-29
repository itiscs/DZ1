using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    public class Equation
    {
        protected int countSol;

        public static Equation CreateEquation(double a,double b,double c)
        {
           if (a == 0 && b == 0)
                return new Equation0(c);
            if (a == 0)
                return new Equation1(b, c);
            return new Equation2(a, b, c);
        }


        public virtual void Solve()
        {
            PrintSolution();
        }

        public virtual void PrintSolution()
        {
            //return String.Format(this.GetType().Name);
            Console.WriteLine("Не известен тип уравнения");
        }
    }

    public class Equation0:Equation
    {
        protected double c;

        public Equation0(double c)
        {
            this.c = c;
        }
        public override void Solve()
        {
            if (c == 0)
                countSol = int.MaxValue;
            else
                countSol = 0; 
        }

        public override void PrintSolution()
        {
            if(countSol == int.MaxValue)
                Console.WriteLine("Ответы вся числовая ось");
            else if(countSol == 0)
                Console.WriteLine("Нет решения");
        }
    }
    public class Equation1 : Equation0
    {
        protected double b;
        protected double x1;

        public Equation1(double b, double c):base(c)
        {
            this.b = b;
        }
        public override void Solve()
        {
            countSol = 1;
            x1 = -c / b;
        }

        public override void PrintSolution()
        {
            Console.WriteLine($"x = {x1}");
        }
    }
    public class Equation2 : Equation1
    {
        protected double a;
        protected double x2;

        public Equation2(double a, double b, double c) : base(b,c)
        {
            this.a = a;
        }
        public override void Solve()
        {
            double d = b * b - 4 * a * c;
            if (d < 0)
                countSol = 0;
            else
            {
                countSol = 2;
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
                
        }

        public override void PrintSolution()
        {
            if(countSol == 0)
                Console.WriteLine("Вещественных решений нет");
            else
                Console.WriteLine($"x1 = {x1}   x2 = {x2}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Equation e = Equation.CreateEquation(1,0,-4);
            e.Solve();
            e.PrintSolution();
        }
    }
}
