using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Vehicle
    {
        public int MaxSpeed { get; protected set; }
        public int YearConstr { get; protected set; }
        public int Probeg { get; protected set; }
        public int CurSpeed { get; protected set; }
        
        public Vehicle(int m, int y, int p, int c)
        {
            MaxSpeed = m;
            YearConstr = y;
            Probeg = p;
            CurSpeed = c;
        }

        
        public abstract void SpeedUp();
        public abstract void SpeedDown();
    }

  
    public class Car:Vehicle
    {
        
        public Car(int m, int y, int p, int c) : base(m, y, p, c)
        {
            

        }

        public override void SpeedUp()
        {
            CurSpeed += 5;
            if (CurSpeed > MaxSpeed)
                CurSpeed = MaxSpeed;
        }
        public override void SpeedDown()
        {
            CurSpeed -= 5;
            if (CurSpeed < 0)
                CurSpeed = 0;
        }
        

    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v;

            Car c1 = new Car(120, 2015, 50, 112);
            Car c2 = new Car(120, 2015, 50, 2);
            v = c1;
            v.SpeedUp();
            v.SpeedUp();
            v.SpeedUp();
            v.SpeedUp();
            c2.SpeedDown();
            c2.SpeedDown();
            c2.SpeedDown();
            c2.SpeedDown();
            Console.WriteLine($"{v} {v.CurSpeed}  {c2.CurSpeed}");
        }
    }
}
