using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2Q3
{
    public class TemperatureTracker
    {
        public double[] Temperature = new double[7];

        public void DailyTemperature()
        {
            for (int i = 0; i < 7; i++)
            {
                //$ for strings with dynamic content.
                Console.Write($" Enter the temperature for a day{i + 1}: ");
                Temperature[i] = double.Parse(Console.ReadLine());
            }
        }
        public void Report()
        {
            Console.WriteLine("Weekly temperature report:");

            for (int i = 0; i < 7; i++)
            {
                Console.Write($" Day[i+1]: {Temperature[i]} Celsius");
                Temperature[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker tracker = new TemperatureTracker();

            tracker.DailyTemperature();
            Console.WriteLine("\n");
            tracker.Report();

            Console.ReadLine();
        }
    }
}