using System;

public class Money
{
    public int Dollars { get; set; }
    public int Cents { get; set; }
    public string Currency { get; set; }

    public Money(int dollars, int cents, string currency)
    {
        Dollars = dollars;
        Cents = cents;
        Currency = currency;
    }

    public void DisplayAmount()
    {
        Console.WriteLine($"Amount: {Dollars} {Currency} and {Cents} cents");
    }
}
