using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            if (budget > 0 && budget <= 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", budget * 0.3);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0}", budget * 0.7);
                }
            }
            if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", budget * 0.4);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", budget * 0.8);
                }
            }
            else if (budget > 1000)
            {
                if (season == "summer" || season == "winter")
                {
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", budget * 0.9);
                }
            }
        }
    }
}
