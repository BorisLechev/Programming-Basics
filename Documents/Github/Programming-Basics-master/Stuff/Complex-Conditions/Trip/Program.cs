using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var spentMoney = 0.0;
            var holiday = "";
            var country = "";
            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        spentMoney = budget * 0.3;
                        holiday = "Camp";
                        country = "Bulgaria";break;
                    case "winter":
                        spentMoney = budget * 0.7;
                        holiday = "Hotel";
                        country = "Bulgaria"; break;
                }
            }
            else if (budget < 1000)
            {
                switch (season)
                {
                    case "summer":
                        spentMoney = budget * 0.4;
                        holiday = "Camp";
                        country = "Balkans"; break;
                    case "winter":
                        spentMoney = budget * 0.8;
                        holiday = "Hotel";
                        country = "Balkans"; break;
                }
            }
            else
            {
                switch (season)
                {
                    case "summer":
                        spentMoney = budget * 0.9;
                        holiday = "Hotel";
                        country = "Europe"; break;
                    case "winter":
                        spentMoney = budget * 0.9;
                        holiday = "Hotel";
                        country = "Europe"; break;
                }
            }
            Console.WriteLine("Somewhere in {0}", country);
            Console.WriteLine(holiday, spentMoney, "{0;f2}");
        }
    }
}
