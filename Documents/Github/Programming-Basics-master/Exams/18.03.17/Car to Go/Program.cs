using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_to_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Economy class");
                    Console.WriteLine("Cabrio - {0:f2}", budget * 0.35);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Economy class");
                    Console.WriteLine("Jeep - {0:f2}", budget * 0.65);
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Compact class");
                    Console.WriteLine("Cabrio - {0:f2}", budget * 0.45);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Compact class");
                    Console.WriteLine("Jeep - {0:f2}", budget * 0.8);
                }
            }
            else if (budget > 500)
            {
                if (season == "summer" || season == "winter")
                {
                    Console.WriteLine("Luxury class");
                    Console.WriteLine("Jeep - {0:f2}", budget * 0.9);
                }
            }
        }
    }
}
