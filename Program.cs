using System;

class Program
{
    static void Main(string[] args)
    {
        Money price1 = new Money(10, 50, "USD");
        Product product1 = new Product("Book", price1, "Literature", new DateTime(2024, 12, 31));

        Money price2 = new Money(5, 75, "USD");
        Product product2 = new Product("Pen", price2, "Stationery", new DateTime(2024, 12, 31));

        Console.WriteLine("Product 1 Details:");
        product1.DisplayProduct();

        Console.WriteLine("\nProduct 2 Details:");
        product2.DisplayProduct();
    }
}

