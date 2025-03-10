using System;

class Activity2A
{
    public static void Main(string[] args)
    {
        double bonus = 0;

        Console.Write("\nEnter Employee Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Employee Years of Service: ");
        int years = Convert.ToInt32(Console.ReadLine());

        if (years > 10)
        {
            bonus = salary * 0.10;
        }
        else if (years >= 5)
        {
            bonus = salary * 0.05;
        }
        else if (years > 0)
        {
            bonus = salary * 0.02;
        }
        else
        {
            Console.WriteLine("Invalid Input.");
            return;
        }
        double totSalary = salary + bonus;

        Console.WriteLine("\n\tBonus Salary: " +bonus);
        Console.WriteLine("\tTotal Salary: "+totSalary);
    }
}