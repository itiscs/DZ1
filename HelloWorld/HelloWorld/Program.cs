using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            long m = 1, p = 1, n;
            n = long.Parse(Console.ReadLine());
            int k = 1;//иниц счетчика
            while(k<=n)  //проверка усл
            {
                m *= k;    //основные действия в цикле
                k++;      //изм.счетчика
            }

            for(int i=1; i<= n; i++)
            {
                p *= i;
            }
            
           
            Console.WriteLine("n!={0} n!={1}", m, p);





        }
    }
}
