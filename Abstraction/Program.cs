using Abstraction;
using Abstraction.Products;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

try
{
    Product mavic = new Drones("Мавік",13000,4, "USA", 3, 7);
    Product ak47 = new Weapon("АК-47", 10500,4, "standard", "caliber");
    Product blanketArmor = new Armor("Бронековдра", 4, 3, "people", "polyethylene", 9.96F);

    ShoppingCart cart = new ShoppingCart();

    cart.AddProduct(blanketArmor, 1);

    cart.AddProduct(mavic,2);

    cart.AddProduct(ak47, 1);

    cart.AddProduct(blanketArmor, 1);
    Console.Write(cart.ShowInfoAboutAllProducts());
    Console.Write(cart.SumOfShoppingCart());
}
catch (ShoppingCartException ex)
{
    Console.WriteLine(ex.Message);
    Console.Write($"Неможливо придбати {ex.CountThingsWhichCustomerWantBuy} одиниць товару під назвою '{ex.Name}' при залишку товару у кількості {ex.Availability}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

