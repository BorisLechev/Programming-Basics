using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_price
{
    class Program
    {
        static void Main(string[] args)
        {
            var thesmallestRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var pricekm2 = double.Parse(Console.ReadLine());
            var bathroom = thesmallestRoom * 0.5;
            var secondRoom = thesmallestRoom + thesmallestRoom * 0.1;
            var thirdRoom = secondRoom + secondRoom * 0.1;
            var total = thesmallestRoom + kitchen + bathroom + secondRoom + thirdRoom;
            var flat = total + total * 0.05;
            var priceflat = flat * pricekm2;
            Console.WriteLine("{0:f2}", priceflat);
        }
    }
}
