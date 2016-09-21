using System;

public class OddEven
{
    public static void Main(string[] args)
    {
        int number;

        Console.Write("Enter integer: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine("{0}", "This number is even");

        else
            Console.WriteLine("{0}", "This number is odd");
    }
}