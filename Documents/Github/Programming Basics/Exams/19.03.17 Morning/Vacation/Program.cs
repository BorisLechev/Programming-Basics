using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            if (budget <= 1000)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Alaska - Camp {0:f2}", budget * 0.65);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Marocco - Camp {0:f2}", budget * 0.45);
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Alaska - Hut {0:f2}", budget * 0.8);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Marocco - Hut {0:f2}", budget * 0.6);
                }
            }
            else if (budget > 3000)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Alaska - Hotel {0:f2}", budget * 0.9);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Marocco - Hotel {0:f2}", budget * 0.9);
                }
            }
        }
    }
}
