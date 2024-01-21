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
        public string CountryProducing { get; set; }
        public short Generation { get; set; }
        public short YearsUsing { get; set; }

        public Drones(string name, float price, int count, string countryProducing, short generation, short yearsUsing)
            : base(name, price, count)
        {
            CountryProducing = countryProducing;
            Generation = generation;
            YearsUsing = yearsUsing;
        }

        public override string Display()
        {
            return $"Назва товару:{Name},ціна {Name}(-a/y/и) становить {Price},к-сть:{Count},країна-виробник {CountryProducing},покоління {Generation},термін використання(роки) {YearsUsing}";

        }
    }
}
