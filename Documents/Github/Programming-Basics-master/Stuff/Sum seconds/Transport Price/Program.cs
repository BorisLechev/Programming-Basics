using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var daytime = Console.ReadLine().ToString();
            double taxistart = 0.70;
            double taxiday = 0.79;
            double taxinight = 0.90;
            double bus = 0.09;
            double train = 0.06;
            if (km < 20 && daytime == "day")
            {
                Console.WriteLine((km * taxiday) + taxistart);
            }
            else if (km < 20 && daytime == "night")
            {
                Console.WriteLine((km * taxinight) + taxistart);
            }
            else if (km < 100 && km >= 20)
            {
                Console.WriteLine(km * bus);
            }
            else if (km >= 100)
            {
                Console.WriteLine(km * train);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
