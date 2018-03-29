using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;
            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number >= 1 && number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    p2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            Console.WriteLine("{0:f2}%", p1 / n * 100);
            Console.WriteLine("{0:f2}%", p2 / n * 100);
            Console.WriteLine("{0:f2}%", p3 / n * 100);
            Console.WriteLine("{0:f2}%", p4 / n * 100);
            Console.WriteLine("{0:f2}%", p5 / n * 100);
        }
    }
}
