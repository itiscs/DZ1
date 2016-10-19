using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IArOper> li = new List<IArOper>();

            
            li.Add(new TwoInt(6, 3));
            li.Add(new ThreeInt(24, 4, 2));

            foreach(var l in li)
            {
                Console.WriteLine(l);
                Console.WriteLine($"Summa = {l.Sum()}");
                Console.WriteLine($"Разн = {l.Minus()}");
                Console.WriteLine($"Произв = {l.Prod()}");
                Console.WriteLine($"Деление = {l.Div()}");
                Console.WriteLine("**********************************");
            }

            


        }
    }
}
