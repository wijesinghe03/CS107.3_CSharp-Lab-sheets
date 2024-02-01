using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            Console.Write("Enter marks: ");
            int marks = int.Parse(Console.ReadLine());
            char grade;

            if (marks >= 100)
            {
                Console.WriteLine("Invalid marks");
            }
            else if (marks >= 75)
            {
                grade = 'A';
            }
            else if (marks >= 60)
            {
                grade = 'B';
            }
            else if (marks >= 50)
            {
                grade = 'C';
            }
            else if (marks >= 40)
            {
                grade = 'D';
            }
            else if (marks >= 0)
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Your grade is: " + grade);
        }
    }
}