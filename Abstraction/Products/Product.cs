using System;

namespace Abstraction.Products
{
    public abstract class Product
    {
        private float _price;
        private int _count;

        public string Name { get; set; }

        public float  Price
        {
            get => _price;
            set
            {
                if (value > 0)
                    _price = value;
                else
                    throw new Exception("Ціна має бути додатньою");
            }
        }

        public int Count
        {
            get => _count;
            set
            {
                if (value >= 0)
                    _count = value;
                else
                    throw new Exception("К-сть предметів має бути додатньою");
            }
        }

        public Product(string name, float price, int count)
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