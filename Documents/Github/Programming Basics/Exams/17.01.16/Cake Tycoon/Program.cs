using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Tycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var f = int.Parse(Console.ReadLine());
            var t = int.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            var cakes = f / c;
            if (n < cakes)
            {
                var trufflesCost = t * p;
                var cakePrice = (trufflesCost / n) * 1.25;
                Console.WriteLine("All products available, price of a cake: {0:f2}", cakePrice);
            }
            else
            {
                var requiredFlour = n * c;
                var kgNeeded = requiredFlour - f;
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour", cakes, kgNeeded);
            }
        }
    }
}
