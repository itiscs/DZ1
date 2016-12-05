using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

    }

    interface IFigure
    {
        void Move(double x, double y);
        void Scale(double angle);
        double Area();
        bool IsEqual(IFigure f);
        bool IsContain(IFigure f);
    }

    public class Treug : IFigure
    {
        Point  
        public double Area()
        {
            throw new NotImplementedException();
        }

        public bool IsContain(IFigure f)
        {
            throw new NotImplementedException();
        }

        public bool IsEqual(IFigure f)
        {
            throw new NotImplementedException();
        }

        public void Move(double x, double y)
        {
            throw new NotImplementedException();
        }

        public void Scale(double angle)
        {
            throw new NotImplementedException();
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
