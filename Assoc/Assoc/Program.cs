using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] custs = new Customer[3];
            custs[0] = new Customer()
            {
                Code = 1,
                ContactPhone = "111111111",
                FullName = "Покупатель 1",
                Priveleged = true
            };
            custs[1] = new Customer()
            {
                Code = 2,
                ContactPhone = "2222222222",
                FullName = "Покупатель 2",
                Priveleged = false
            };
            custs[2] = new Customer()
            {
                Code = 3,
                ContactPhone = "33333333",
                FullName = "Покупатель 3",
                Priveleged = false
            };
            for (int i = 0; i < 3; i++)
                Console.WriteLine(custs[i]);

            Item[] items = new Item[5];
            items[0] = new Item() { Article = 1111, Name = "Товар 1", UnitPrice = 100m };
            items[1] = new Item() { Article = 2222, Name = "Товар 2", UnitPrice = 50m };
            items[2] = new Item() { Article = 3333, Name = "Товар 3", UnitPrice = 200m };
            items[3] = new Item() { Article = 4444, Name = "Товар 4", UnitPrice = 300m };
            items[4] = new Item() { Article = 5555, Name = "Товар 5", UnitPrice = 1000m };

            for (int i = 0; i < 5; i++)
                Console.WriteLine(items[i]);

            Order o = new Order();
            o.CreationDate = DateTime.Now;
            Console.WriteLine("Введите номер");
            o.Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите адрес");
            o.Address = Console.ReadLine();
            Console.WriteLine("Введите номер покупателя");
            int k = int.Parse(Console.ReadLine());
            o.Customer = custs[k - 1];
            Console.WriteLine("Срочность - true/false");
            o.Express = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество товаров");
            k = int.Parse(Console.ReadLine());
            for(int i=0;i< k;i++)
            {
                Console.WriteLine("Введите номер товара");
                int t = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество товара");
                int kol = int.Parse(Console.ReadLine());
                o.Lines.Add(new OrderLine() {
                    Quantity = kol, Item = items[t - 1] });
            }

            Console.WriteLine(o);
            Console.WriteLine($"Стоимость {o.Cost()}");
            if(o.IsDiscounted())
                Console.WriteLine($"Стоимость со скидкой {o.CostWithDisount()}");













        }
    }
}
