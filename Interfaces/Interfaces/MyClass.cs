using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Vehicle
    {
        private int curSpeed, maxSpeed;

        public abstract void SpeedUp();
        public abstract void SpeedDown();

    }


    interface IArOper
    {
        int Sum();
        int Minus();
        int Prod();
        int Div();
    }

    class TwoInt:IArOper
    {
        private int a;
        private int b;

        public TwoInt(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return String.Format($"TwoInt: {a} {b}");
        }

        public int Div()
        {
            return a / b;
        }

        public int Minus()
        {
            return a - b; 
        }

        public int Prod()
        {
            return a * b; 
        }

        public int Sum()
        {
            return a + b; 
        }
    }

    class ThreeInt : IArOper
    {
        private int a;
        private int b;
        private int c;

        public ThreeInt(int a, int b, int  c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override string ToString()
        {
            return String.Format($"ThreeInt: {a} {b} {c}");
        }

        public int Div()
        {
            return a / b / c;
        }

        public int Minus()
        {
            return a - b - c;
        }

        public int Prod()
        {
            return a * b * c;
        }

        public int Sum()
        {
            return a + b + c;
        }
    }
}
