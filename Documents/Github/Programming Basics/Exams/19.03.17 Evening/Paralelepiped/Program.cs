using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('+', 1) + new string('~', n - 2) + '+' + new string('.', (2 * n) + 1));
            for (int i = 0; i < (2 * n) + 1; i++)
            {
                Console.WriteLine('|' + new string('.', i) + '\\' + new string('~', n - 2) + '\\' + new string('.', (2 * n) - i));
            }
            for (int i = 0; i < (2 * n) + 1; i++)
            {
                Console.WriteLine(new string('.', i) + '\\' + new string('.', (2 * n) - i) + '|' + new string('~', n - 2) + '|');
            }
            Console.WriteLine(new string('.', (2 * n) + 1) + '+' + new string('~', n - 2) + '+');
        }
    }
}
