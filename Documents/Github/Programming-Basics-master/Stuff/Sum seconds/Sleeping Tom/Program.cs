using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleeping_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var gameYear = 30000;
            var weekendDays = n * 127;
            var workDays = (365 - n) * 63;
            var result = weekendDays + workDays;
            var lastResult = Math.Abs(gameYear - result);
            var hour = lastResult / 60;
            var minutes = lastResult % 60;
            if (gameYear >= result)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hour, minutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hour, minutes);
            }
        }
    }
}
