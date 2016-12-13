using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assoc
{
    public class Customer
    {
        public int Code { get; set; }
        public string ContactPhone { get; set; }
        public string FullName { get; set; }
        public bool Priveleged { get; set; }

        public override string ToString()
        {
            return String.Format($"Покупатель {FullName}, телефон - {ContactPhone}, Привилегированный - {Priveleged} ");
        }
    }
}
