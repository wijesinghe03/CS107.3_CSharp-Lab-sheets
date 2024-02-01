using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine(number + "*" + i + " = " + number * i);
            }
        }
    }
}
