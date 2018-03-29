using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var hrizantemi = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var tulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var day = Console.ReadLine();
            var pricehrizantemi = 0.0;
            var priceroses = 0.0;
            var pricetulips = 0.0;
            var total = 0.0;
            var allFlowers = hrizantemi + roses + tulips;
            if (season == "Spring")
            {
                pricehrizantemi = 2.0;
                priceroses = 4.1;
                pricetulips = 2.5;
                total = (hrizantemi * pricehrizantemi) + (roses * priceroses) + (tulips * pricetulips);
                if (day == "Y")
                {
                    total = total + total * 0.15;
                    if (tulips > 7)
                    {
                        total = total - total * 0.05;
                    }
                }
                else if (day == "N")
                {
                    if (tulips > 7)
                    {
                        total = total - total * 0.05;
                    }
                }
            }
            else if (season == "Summer")
            {
                pricehrizantemi = 2.0;
                priceroses = 4.1;
                pricetulips = 2.5;
                total = (hrizantemi * pricehrizantemi) + (roses * priceroses) + (tulips * pricetulips);
                if (day == "Y")
                {
                    total = total + total * 0.15;
                }
            }
            else if (season == "Autumn")
            {
                pricehrizantemi = 3.75;
                priceroses = 4.5;
                pricetulips = 4.15;
                total = (hrizantemi * pricehrizantemi) + (roses * priceroses) + (tulips * pricetulips);
                if (day == "Y")
                {
                    total = total + total * 0.15;
                    if (roses >= 10)
                    {
                        total = total - (total * 0.1);
                    }
                }
                else if (day == "N")
                {
                    if (roses > 10)
                    {
                        total = total - (total * 0.1);
                    }
                }

            }
            else if (season == "Winter")
            {
                pricehrizantemi = 3.75;
                priceroses = 4.5;
                pricetulips = 4.15;
                total = (hrizantemi * pricehrizantemi) + (roses * priceroses) + (tulips * pricetulips);
                if (day == "Y")
                {
                    total = total + (total * 0.15);
                    if (roses >= 10)
                    {
                        total = total - (total * 0.1);
                    }
                }
                else if (day == "N")
                {
                    if (roses >= 10)
                    {
                        total = total - (total * 0.1);
                    }
                }
            }
            if (allFlowers > 20)
            {
                total = total - (total * 0.2) + 2;
            }
            else if (allFlowers <= 20)
            {
                total = total + 2;
            }
            Console.WriteLine("{0:f2}", total);
        }
    }
}
