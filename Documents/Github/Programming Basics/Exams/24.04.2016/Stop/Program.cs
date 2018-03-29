using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var countS = 0;
            Console.WriteLine(new string('.', n + 1) + new string('_', 2 * n + 1) + new string('.', n + 1));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n - i) + new string('/', 2) + new string('_', 2 * n - 1 + count) + new string('\\', 2) + new string('.', n - i));
                count = count + 2;
            }
            Console.WriteLine(new string('/', 2) + new string('_', n * 2 - 3) + "STOP!" + new string('_', n * 2 - 3) + new string('\\', 2));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', i) + new string('\\', 2) + new string('_', n * 4 - 1 - countS) + new string('/', 2) + new string('.', i));
                countS = countS + 2;
            }
        }
    }
}
