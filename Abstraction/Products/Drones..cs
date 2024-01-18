using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstraction.Products
{
    public class Drones : Product
    {
        public string Country { get; set; }
        public short Generation { get; set; }
        public short YearsGeneration { get; set; }

        public Drones(string name, float price, short count, string country, short generation, short yearsGeneration)
            : base(name, price, count)
        {
            Country = country;
            Generation = generation;
            YearsGeneration = yearsGeneration;
        }

        public override string Display()
        {
            return $"Назва товару:{Name},ціна {Name}(-a/y) становить {Price},к-сть:{Count}";
        }
    }
}
