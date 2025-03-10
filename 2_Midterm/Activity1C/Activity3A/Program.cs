using System;

class Activity3A
{
    public static void Main(string[] args)
    {
        double totAmount = 0;
        double discount;

        Console.Write("\nEnter the Total Amount of Purchase: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount > 5000)
        {
            discount = amount * 0.20;
        }
        else if (amount > 2000)
        {
            discount = amount * 0.10;
        }
        else
        {
            discount = 0.0;
        }

        totAmount = amount - discount;

        Console.Write("\n\tTotal Amount Without Discount: " + amount);
        Console.Write("\n\tDiscount Amount: " + discount);
        Console.Write("\n\tTotal Amount With Discount: " + totAmount);

        Console.WriteLine();

    }
}
