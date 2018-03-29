using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets_for_a_Football_match
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double ticketSum = 0.0;
            double transport = 0.0;
            switch (category)
            {
                case "VIP":
                    ticketSum = people * 499;
                    break;
                case "Normal":
                    ticketSum = people * 249.99;
                    break;
                    
            }
            if (people >= 1 && people <= 4)
            {
                transport = budget * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                transport = budget * 0.6;
            }
            else if (people >= 10 && people <= 24)
            {
                transport = budget * 0.5;
            }
            else if (people >= 25 && people <= 49)
            {
                transport = budget * 0.4;
            }
            else if (people >= 50)
            {
                transport = budget * 0.25;
            }
            double restMoney = budget - transport;
            double money = Math.Abs(restMoney - ticketSum);
            if (budget > money)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", money);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", money);
            }
        }
    }
}
