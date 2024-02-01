using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fibonacci series
            int number;
            Console.Write("Enter a number:");
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                int result = Fibonacci(i);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }

        static int Fibonacci(int i)
        {
            if (i <= 1)
            {
                return i;
            }
            else
            {
                return Fibonacci(i - 1) + Fibonacci(i - 2);
            }
        }
    }
}