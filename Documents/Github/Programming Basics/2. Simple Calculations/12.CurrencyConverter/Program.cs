using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            var first = Console.ReadLine().ToLower();
            var second = Console.ReadLine().ToLower();

            if (first == "usd")
            {
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.79549, 2) + " BGN");
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.91801, 2) + " EUR");
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.70854, 2) + " GBP");
                }

            }

            if (first == "bgn")
            {
                if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(num / 1.79549, 2) + " USD");
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(num / 1.95583, 2) + " EUR");
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(num / 2.53405, 2) + " GBP");
                }
            }

            if (first == "eur")
            {
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 2.53405, 2) + " BGN");
                }
                else if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.08930, 2) + " USD");
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.77181, 2) + " GBP");
                }
            }
            if (first == "gbp")
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.39462, 2) + "BGN");
                }
                else if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(num * 2.53405 / 1.79549, 2) + " USD");
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.77181, 2) + " EUR");
                }
        }
    }
}
