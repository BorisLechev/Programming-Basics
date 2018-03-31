using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamand_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}", new string('.', n), new string('*', n * 3), new string('.', n));
            for (var k = n - 1; k > 0; k--)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('.', k), new string('.', ((5 * n) - 2 - (2 * k))));
            }
            Console.WriteLine("{0}", new string('*', 5 * n));
            var i = 1;
            for (i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', (5 * n - 2 - 2 * i)));
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('*', (5 * n - 2 - 2 * i)));

        }
    }
}
