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

        public int _generation;
        public int Generation { 
            get => _generation;
            set {
                if (value > 0)
                    _generation = value;
                else throw new Exception("Покоління має бути натуральним");
            } 
        }
        public ushort YearsUsing { get; set; }

        public Drones(string name, float price, int count, string countryProducing,int generation, ushort yearsUsing)
            : base(name, price, count)
        {
            CountryProducing = countryProducing;
            Generation = generation;
            YearsUsing = yearsUsing;
        }

        public override string Display()
        {
            return $"Назва товару:{Name},ціна {Name}(-a/y/и) становить {Price},к-сть даного товару на складі:{Count},країна-виробник {CountryProducing},покоління {Generation},термін використання(роки) {YearsUsing}";

        }
    }
}
