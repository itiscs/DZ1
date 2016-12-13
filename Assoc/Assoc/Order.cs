using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assoc
{
    public class Order
    {
        public int Number { get; set; }
        public DateTime CreationDate { get; set; }
        public string Address { get; set; }
        public bool Express { get; set; }
        public Customer Customer { get; set; }
        public List<OrderLine> Lines { get; set; } = new List<OrderLine>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Заказ номер: {Number} Дата - {CreationDate} Экспресс - {Express}\n");
            sb.Append($"Заказчик - {Customer}\n");
            foreach(OrderLine l in Lines)
                sb.Append($"Количество {l.Quantity} Товар - {l.Item}\n");
            return sb.ToString();
        }

        public decimal Cost()
        {
            decimal cost = 0;
            foreach(OrderLine l in Lines)
            {
                cost += l.Quantity * l.Item.UnitPrice;
            }
            //cost = Express ? (cost * 1.25m) : cost;
            if (Express)
                cost *= 1.25m;
            return cost;
        }

        public bool IsDiscounted()
        {
            return Cost() > 1500 && Customer.Priveleged;
        }

        public decimal CostWithDisount()
        {
            if (IsDiscounted())
                return Cost() * 0.85m;
            return Cost();
        }


    }
}
