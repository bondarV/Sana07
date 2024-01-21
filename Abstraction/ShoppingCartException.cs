using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class ShoppingCartException:Exception
    {
        public string Name {  get; set; }
        public int Availability {  get; set; }
        public short CountThingsWhichCustomerWantBuy {  get; set; }
        public ShoppingCartException(string name,int availability, short countThingsWhichCustomerWantBuy, string message)
            :base(message)
        {
            Name = name;
            Availability = availability;
            CountThingsWhichCustomerWantBuy = countThingsWhichCustomerWantBuy;
        }
    }   
}
