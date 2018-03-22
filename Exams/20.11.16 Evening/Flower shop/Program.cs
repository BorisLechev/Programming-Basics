using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactusi = int.Parse(Console.ReadLine());
            double priceForGift = double.Parse(Console.ReadLine());
            double priceMagnolii = magnolii * 3.25;
            double priceZumbuli = zumbuli * 4;
            double priceRoses = roses * 3.5;
            double priceCactusi = cactusi * 8;
            double sum = priceMagnolii + priceZumbuli + priceRoses + priceCactusi;
            double tax = sum * 0.05;
            double profit = sum - tax;
            double lv1 = Math.Ceiling(priceForGift - profit);
            double lv2 = Math.Floor(profit - priceForGift);
            if (profit > priceForGift)
            {
                Console.WriteLine("She is left with {0} leva.", lv2);
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", lv1);
            }
        }
    }
}
