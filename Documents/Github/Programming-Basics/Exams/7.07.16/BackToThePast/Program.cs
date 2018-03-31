using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            var inheritance = double.Parse(Console.ReadLine());
            var yearsToLive = int.Parse(Console.ReadLine());
            var years = 18;
            for (var i = 1800; i <= yearsToLive; i++)
            {
                if (i % 2 == 0)
                {
                    inheritance -= 12000;
                }
                else
                {
                    inheritance -= (12000 + 50 * years);
                }
                years++;
            }
            if (inheritance < 0)
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(inheritance));
            }
            else
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", inheritance);
            }
        }
    }
}
