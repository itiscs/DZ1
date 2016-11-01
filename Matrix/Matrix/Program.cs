using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static int Sum(ref int a, ref int b)
        {
            //a = 5;
            //b = 5;
            return a + b;
        }

        static int[,] pro(int[,] a, int[,] b, int n)
        {
            int[,] c = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return c;
        }


        static void Change(ref int a, ref int b)
        {
            int k = a;
            a = b;
            b = k;           
        }

        static void ShowMass(int[,] mas, int n, int m)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{mas[i, j]} ");

                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int k, l, mm;

            Random r = new Random();

            k = r.Next(100);
            l = r.Next(100);

            mm = Sum(ref k, ref l);

            Console.WriteLine($"{k}+{l}={mm}");

            Change(ref k, ref l);
            Console.WriteLine($"k = {k}, l = {l}");

            int n = 5, m = 5;
            int[,] a = new int[m, n];


            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = i + j;
            
            ShowMass(a, n, m);

            int[,] b = new int[n, n];
            for (int i = 0; i < n; i++)
                b[i, i] = 1;

            int st = int.Parse(Console.ReadLine());
            for (int i = 0; i < st; i++)
            {
                b = pro(a, b, n);
            }

            ShowMass(b, n, n);


        }
    }
}
