using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var excursion = double.Parse(Console.ReadLine());
            var puzzle = int.Parse(Console.ReadLine());
            var talkingDoll = int.Parse(Console.ReadLine());
            var teddyBear = int.Parse(Console.ReadLine());
            var minions = int.Parse(Console.ReadLine());
            var trucks = int.Parse(Console.ReadLine());
            var sum = puzzle * 2.6 + talkingDoll * 3 + teddyBear * 4.1 + minions * 8.2 + trucks * 2;
            var numberToys = puzzle + talkingDoll + teddyBear + minions + trucks;
            if (numberToys > 50)
            {
                var discount = sum * 0.25;
                var finalPrice = sum - discount;
                var profit = finalPrice - finalPrice * 0.1;
                var lv = Math.Abs(profit - excursion);
                if (profit > excursion)
                {
                    Console.WriteLine("Yes! {0:f2} lv left.", lv);
                }
            }
            if (numberToys < 50)
            {
                var profit = sum - sum * 0.1;
                var lv = Math.Abs(profit - excursion);
                if (profit < excursion)
                {
                    Console.WriteLine("Not enough money! {0:f2} lv needed.", lv);
                }
            }
        }
    }
}
