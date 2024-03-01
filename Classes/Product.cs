using System;

public class Product
{
    public string Name { get; set; }
    public Money Price { get; set; }
    public string Category { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Product(string name, Money price, string category, DateTime expiryDate)
    {
        Name = name;
        Price = price;
        Category = category;
        ExpiryDate = expiryDate;
    }

    public void ReducePrice(int amount)
    {
        if (Price.Cents >= amount)
        {
            Price.Cents -= amount;
        }
        else
        {
            int deficit = amount - Price.Cents;
            Price.Cents = 100 - deficit;
            Price.Dollars -= 1;
        }
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price.Dollars} {Price.Currency} and {Price.Cents} cents");
        Console.WriteLine($"Category: {Category}, Expiry Date: {ExpiryDate.ToShortDateString()}");
    }
}
