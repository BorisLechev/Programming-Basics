using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kmforMonth = double.Parse(Console.ReadLine());
            var salary1 = (kmforMonth * 4 * 0.75) - (kmforMonth * 4 * 0.75 * 0.1);
            var salary2 = (kmforMonth * 4 * 0.9) - (kmforMonth * 4 * 0.9 * 0.1);
            var salary3 = (kmforMonth * 4 * 1.05) - (kmforMonth * 4 * 1.05 * 0.1);
            var salary4 = (kmforMonth * 4 * 0.95) - (kmforMonth * 4 * 0.95 * 0.1);
            var salary5 = (kmforMonth * 4 * 1.1) - (kmforMonth * 4 * 1.1 * 0.1);
            var salary6 = (kmforMonth * 4 * 1.25) - (kmforMonth * 4 * 1.25 * 0.1);
            var salary7 = (kmforMonth * 4 * 1.45) - (kmforMonth * 4 * 1.45 * 0.1);
            if (kmforMonth <= 5000)
            {
                if (season == "spring" || season == "autumn")
                {
                    Console.WriteLine("{0:f2}", salary1);
                }
                else if (season == "summer")
                {
                    Console.WriteLine("{0:f2}", salary2);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("{0:f2}", salary3);
                }
            }
            else if (kmforMonth > 5000 && kmforMonth <= 10000)
            {
                if (season == "spring" || season == "autumn")
                {
                    Console.WriteLine("{0:f2}", salary4);
                }
                else if (season == "summer")
                {
                    Console.WriteLine("{0:f2}", salary5);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("{0:f2}", salary6);
                }
            }
            if (kmforMonth > 10000 && kmforMonth <= 20000)
            {
                if (season == "spring" || season == "autumn")
                {
                    Console.WriteLine("{0:f2}", salary7);
                }
                else if (season == "summer")
                {
                    Console.WriteLine("{0:f2}", salary7);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("{0:f2}", salary7);
                }
            }
        }
    }
}
