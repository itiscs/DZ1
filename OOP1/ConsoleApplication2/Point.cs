using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(double x) : this(x, x) { }
        public Point() : this(0, 0) { }

        public double Module()
        {
            return Math.Sqrt(x * x + y * y);
        }


        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }

        public override string ToString()
        {
            return String.Format($"Point - ({x},{y})");
        }



    }

}
