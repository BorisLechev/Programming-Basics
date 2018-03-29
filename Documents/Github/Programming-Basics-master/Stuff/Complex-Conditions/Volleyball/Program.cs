using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var weekendsVGodina = 48;
            var weekendsVSofia = (weekendsVGodina - h) * 3.0 / 4;
            var igriVGrada = h;
            var igriVSofia = holidays * 2.0 / 3;
            var all = igriVGrada + igriVSofia + weekendsVSofia;
            var ifYear = 0.0;
            if (year == "leap")
            {
                ifYear = (15 * all) / 100;
            }
            var final = Math.Truncate(ifYear + all);
                Console.WriteLine(final);
        }
    }
}
