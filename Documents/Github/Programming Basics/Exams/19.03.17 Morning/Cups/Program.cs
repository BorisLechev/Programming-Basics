using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberCups = int.Parse(Console.ReadLine());
            var numberWorkers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());
            var workHours = 8;
            var work = numberWorkers * workDays * workHours;
            var cups = work / 5;
            var result = Math.Abs(cups - numberCups);
            if (cups < numberCups)
            {
                Console.WriteLine("Losses: {0:f2}", result * 4.2);
            }
            else if (cups >= numberCups)
            {
                Console.WriteLine("{0:f2} extra money", result * 4.2);
            }
        }
    }
}
