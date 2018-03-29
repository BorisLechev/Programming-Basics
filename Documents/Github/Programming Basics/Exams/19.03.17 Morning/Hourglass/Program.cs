using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            Console.WriteLine(new string('*', 2 * n + 1));
            Console.WriteLine(new string('.', 1) + '*' + new string(' ', (2 * n) - 3) + '*' + '.');
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string('.', 2 + i) + '*' + new string('@', ((2 * n) - 5) - count) + '*' + new string('.', 2 + i));
                count = count + 2;
            }
            Console.WriteLine(new string('.', n) + '*' + new string('.', n));
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string('.', (n - 1) - i) + '*' + new string(' ', i) + '@' + new string(' ', i) + '*' + new string('.', (n - 1) - i));
            }
            Console.WriteLine(new string('.', 1) + '*' + new string('@', (2 * n) - 3) + '*' + '.');
            Console.WriteLine(new string('*', (2 * n) + 1));
        }
    }
}
