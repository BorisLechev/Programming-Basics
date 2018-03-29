using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumriaPrice = double.Parse(Console.ReadLine());
            var cacaPrice = double.Parse(Console.ReadLine());
            var palamud = double.Parse(Console.ReadLine());
            var safrid = double.Parse(Console.ReadLine());
            var shells = int.Parse(Console.ReadLine());
            var palamudPrice = skumriaPrice * 1.6;
            var sumPalamud = palamud * palamudPrice;
            var safridPrice = cacaPrice * 1.8;
            var sumSafrid = safrid * safridPrice;
            var shellsSum = shells * 7.5;
            var check = sumPalamud + sumSafrid + shellsSum;
            Console.WriteLine("{0:f2}", check);
        }
    }
}
