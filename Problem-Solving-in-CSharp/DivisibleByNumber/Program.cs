using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_in_CSharp.DivisibleByNumber
{
  class DivisibleByFive
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            CheckDivisibleByFive(number);
            Console.ReadKey();

        }
        public static void CheckDivisibleByFive(int number)
        {
            if (number < 1)
            {
                Console.WriteLine($"{number} is invalid number");
                return;
            }
            if(number % 5 == 0) {
                Console.WriteLine($"{number} is divisible by 5");

            }
            else
            {
                Console.WriteLine($"{number} is not divisible by 5");
            }
        }
    }
}
