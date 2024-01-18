using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Products
{
    public abstract class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public short Count {  get; set; }

        public Product(string name, float price, short count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
            Count = 1;
        }

        public abstract string Display();

    }
}
