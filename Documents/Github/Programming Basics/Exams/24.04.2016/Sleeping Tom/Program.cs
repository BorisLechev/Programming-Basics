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
            var restDays = int.Parse(Console.ReadLine());
            var workDays = 365 - restDays;
            var timeforGames = workDays * 63 + restDays * 127;
            var totalMin = 30000 - timeforGames;
            var hours = Math.Abs(totalMin / 60);
            var minutes = Math.Abs(totalMin % 60);
            if (30000 < timeforGames)
            {
                Console.WriteLine("Tom will run away {0} hours and {1} minutes more for play", hours, minutes);
            }
            else if (30000 > totalMin)
            {
                Console.WriteLine("Tom sleeps well {0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
