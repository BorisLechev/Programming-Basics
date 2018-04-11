using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaVineyard = double.Parse(Console.ReadLine());
            var kgfromM2 = double.Parse(Console.ReadLine());
            var scrap = double.Parse(Console.ReadLine());
            var grapes = areaVineyard * kgfromM2 - scrap;
            var rakia = grapes * 0.45 / 7.5;
            var income = rakia * 9.8;
            var forSell = grapes * 0.55;
            var income2 = forSell * 1.5;
            Console.WriteLine("{0:f2}", income);
            Console.WriteLine("{0:f2}", income2);
        }
    }
}
