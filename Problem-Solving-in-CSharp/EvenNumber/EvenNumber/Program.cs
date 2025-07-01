using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Number you want want to print");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+ " ");
                }
            }
        }
    }
}
