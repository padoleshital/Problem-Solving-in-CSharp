using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationOfFactor
{
    internal class Program
    {
        static int CalculateDiffrence(int number)
        {
            int sumFactor = 0;
            int NonSumFactor = 0;
            for (int i = 1; i <= number; i++)
            {
                if ( number != i)
                {
                    if (number % i == 0)
                    {
                        sumFactor += i;
                        Console.Write(i + " ");
                    }
                    else
                    {
                        NonSumFactor += i;
                        Console.Write(i + " ");
                    }
                }
            }
            Console.WriteLine("Sum of Factors: " + sumFactor);
          
            Console.WriteLine("Sum of Non-Factors: " + NonSumFactor);
           // Console.WriteLine("")

            int diffrence = NonSumFactor - sumFactor;        
            Console.WriteLine("Difference: " + diffrence);
            return diffrence;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
             int Diffrence = CalculateDiffrence(number);
            Console.ReadKey();
        }
    }
}
