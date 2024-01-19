using Abstraction.Products;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Product mavic = new Drones("Мавік", 13000, 2, "USA", 3, 7);
Product ak47 = new Weapon("АК-47", 10500, 1, "standard", "caliber");
Product blanketArmor = new Armor("Бронековдра", 30906F,2, "people", "polyethylene", 3.96F);

ShoppingCart cart = new ShoppingCart();

cart.AddProduct(blanketArmor, 1);

cart.AddProduct(mavic,1);

cart.AddProduct(ak47,1);

cart.AddProduct(blanketArmor,1);
Console.Write(cart.ShowInfoAboutAllProducts());
Console.Write(cart.SumOfShoppingCart());
