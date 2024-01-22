using Abstraction;
using Abstraction.Products;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

try
{
    Product mavic = new Drones("Мавік",13000,5, "USA", 1000, 7);
    Product ak47 = new Weapon("АК-47", 10500,5, "standard", "caliber");
    Product blanketArmor = new Armor("Бронековдра", 4500, 3, "people", "polyethylene", 3.96F);

    ShoppingCart cart = new ShoppingCart();

    cart.AddProduct(blanketArmor, 1);

    cart.AddProduct(mavic,3);

    cart.AddProduct(ak47, 5);

    cart.AddProduct(blanketArmor, 1);
    Console.Write(cart.ShowInfoAboutAllProducts());
    Console.WriteLine(cart.SumOfShoppingCart());
}
catch (ShoppingCartException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine($"Неможливо придбати {ex.CountThingsWhichCustomerWantBuy} одиниць товару під назвою '{ex.Name}' при залишку товару у кількості {ex.Availability}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.Write("Застосувавши термін 'абстрагування' ми відкинули якою валютою ми розраховувалися,тому що наш магазин український");
}

