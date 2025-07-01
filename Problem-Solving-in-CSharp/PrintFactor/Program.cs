using System;

public class Program
{
    public static void PrintFactors(int num)
    {
        Console.WriteLine("Factors of " + num + ":");
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a number For Factorial ");
        int number = Convert.ToInt32(Console.ReadLine());
        PrintFactors(number);         

    }
}
