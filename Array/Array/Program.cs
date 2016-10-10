using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int kol = 0, max = -101, i1=-1, i2=-1;

            Console.WriteLine("размер");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n], b = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
                //  a[i] = int.Parse(Console.ReadLine());
                a[i] = r.Next(-100,100);

            for (int i = 0; i < n; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                    kol = 1;
                    i1 = i2 = i;
                }
                else if (max==a[i])
                {
                    kol++;
                    i2 = i;
                }

            }
            Console.WriteLine($"\n Max = {max} Kol = {kol} i1={i1} i2={i2}");

            int k = 0;
            bool fl = true;
            for (int i = 0; i < n-1; i++)
            {
                if (a[i] * a[i + 1] < 0 || (a[i]==0 && a[i+1]<0) 
                    || (a[i]<0 && a[i+1]==0))
                    k++;
                if (a[i] > a[i + 1])
                    fl = false;

            }





        }
    }
}
