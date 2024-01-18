using Abstraction.Products;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

List <Product> products = new List <Product> (3);

products[1] = new Armor("S", 123F, 2, "people", "iron", 4.23F);
if (products[0] is Armor)
    (products[0] as Armor).Display();

