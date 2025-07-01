using System;

public Program
{

    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int smallestFactor = 0;
        int largestFactor = 0;

        // Find smallest and largest factors
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                if (i != 1 && smallestFactor == 0)
                {
                    smallestFactor = i;
                }
                if (i != num)
                {
                    largestFactor = i;
                }

            }
        }

        int diff = largestFactor - smallestFactor;
        Console.WriteLine("Difference: " + diff);
        Console.WriteLine("Smallest Factor: " + smallestFactor);
        Console.WriteLine("Largest Factor: " + largestFactor);

    }

}


