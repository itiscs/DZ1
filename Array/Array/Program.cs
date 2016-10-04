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
            Console.WriteLine("размер");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n], b = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
                //  a[i] = int.Parse(Console.ReadLine());
                a[i] = r.Next(-100,100);

            int sum = 0, min = a[0], max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (min > a[i])
                    min = a[i];
                if (max < a[i])
                    max = a[i];
                sum += a[i];
                Console.Write($"a[{i}]={a[i]} ");
            }
            Console.WriteLine($"\nSumma = {sum} Max = {max} Min = {min}");











        }
    }
}
