using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Products
{
    public class ShoppingCart
    {
        List<Product> products = new List<Product>(3);

        public void AddProduct (Product product,short amount)
        {
            for(int i = 1;  i <= amount; i++) { 
            products.Add(product);
                product.Count--;
            }
        }

        public string ShowInfoAboutAllProducts()
        {
            StringBuilder cartInfo = new StringBuilder();
            if (products.Count > 0)
            {
                cartInfo.AppendLine("Ваш кошик наразі виглядає так:");
                foreach (Product product in products)
                    cartInfo.AppendLine(product.Display());
            }

            else cartInfo.Append("Ваш кошик наразі порожній");
            return cartInfo.ToString();
        }

        public string SumOfShoppingCart()
        {
            float sum = 0;
            if(products.Count > 0) {
                foreach (Product product in products)
                    sum += product.Price;
            }
            return $"Загальна сума ваших покупок становить {sum}";
        }

    }
}
