using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceWhisky = double.Parse(Console.ReadLine());
            var beer = double.Parse(Console.ReadLine());
            var wine = double.Parse(Console.ReadLine());
            var rakia = double.Parse(Console.ReadLine());
            var whisky = double.Parse(Console.ReadLine());
            var priceRakia = priceWhisky - priceWhisky * 0.5;
            var priceWine = priceRakia - priceRakia * 0.4;
            var priceBeer = priceRakia - priceRakia * 0.8;
            var sumRakia = rakia * priceRakia;
            var sumBeer = beer * priceBeer;
            var sumWine = wine * priceWine;
            var sumWhisky = whisky * priceWhisky;
            var sum = sumBeer + sumRakia + sumWhisky + sumWine;
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
