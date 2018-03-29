using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var m2 = double.Parse(Console.ReadLine());
            var grapesFromM2 = double.Parse(Console.ReadLine());
            var needlitresWine = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var allgrapes = m2 * grapesFromM2;
            var wine = 0.4 * allgrapes / 2.5;
            var reduce = Math.Abs(wine - needlitresWine);
            var reduce1 = Math.Floor(reduce);
            if (wine > needlitresWine)
            {
                Console.WriteLine(reduce);
                var result = reduce / 3;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters. {1} liters left-> {2} liters per person.", wine, reduce, result);
            }
            else
            {
                Console.WriteLine("It will be a tough winter!More {0} liters wine needed.", reduce1);
            }
        }
    }
}
var budget = double.Parse(Console.ReadLine());
var category = Console.ReadLine();
var people = int.Parse(Console.ReadLine());
var moneyLeft = budget;
var result = budget - moneyLeft;
var ticketPrice = category == "VIP" ? 499.99 : 249.99;
            if (people >= 1 && people< 5)
            {
                moneyLeft -= budget* 0.75;
            }
            else if (people >= 5 && people< 10)
            {
                moneyLeft -= budget* 0.6;
            }
            else if (people >= 10 && people< 25)
            {
                moneyLeft -= budget* 0.5;
            }
            else if (people >= 25 && people< 50)
            {
                moneyLeft -= budget* 0.4;
            }
            else if (people > 50)
            {
                moneyLeft -= budget* 0.25;
            }
            var allTickets = people * ticketPrice;
            if (allTickets > moneyLeft)
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", allTickets - moneyLeft);
            }
            else
            {
                moneyLeft -= ticketPrice;
                Console.WriteLine("Yes! You have {0:F2} leva left.",  budget - budget* 0.75 - ticketPrice);
            }