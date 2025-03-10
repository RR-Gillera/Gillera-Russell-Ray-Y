using System;

public class Activity1A
{
    public static void Main(string[] args)
    {
        int i = 0;
        double grade = 1;
        do
        {
            Console.Write("Enter your Grade: ");
            grade = Convert.ToDouble(Console.ReadLine());

            switch (grade)
            {
                case < 1:
                    Console.WriteLine("Invalid grade. Try Again.");
                    break;
                case <= 3.0:
                    Console.WriteLine("You passed!");
                    break;
                case > 5:
                    Console.WriteLine("Invalid grade. Try Again.");
                    break;
                case >= 3.1:
                    Console.WriteLine("You failed.");
                    break;
            }
        }
        while (grade > 5.0 || grade < 1);
    }
}