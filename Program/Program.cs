using Sana07;
using System;
internal class Program
{
    static void Main()
    {
        ShoppingCart cart1 = new ShoppingCart();

        try
        {
            Laptop laptop = new Laptop("Aspire 3 A315", 2500f, "Acer", 16.5f, "Laptop", 25600, 4);
            cart1.addToShoppingCart(laptop);
            Smartphone smartphone = new Smartphone("Galaxy S24 Plus", "Samsung", 6.7f, 120, 1024, "Smartphone", 56999f, 0);
            cart1.addToShoppingCart(smartphone);
            Sana07.Monitor monitor = new Sana07.Monitor("Odissey G5", "Samsung", 27f, 144, "Monitor", 13599f, 16);
            cart1.addToShoppingCart(monitor);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        List<string> productsInfo = cart1.showShoppingCart();
        foreach (string productInfo in productsInfo)
        {
            Console.WriteLine(productInfo);
        }
        Console.WriteLine("Total price of products in the shopping cart: " + cart1.calcilateTotalPrice());
    }
}