using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var countS = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine('#' + new string('~', i) + '#' + new string('.', (n * 2) - count) + '#' + new string('.', count) + '#' + new string('.', (n * 2) - count) + '#' + new string('~', i) + '#');
                count = count + 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', 1 + countS) + '#' + new string('~', n - i) + '#' + new string('.', (n * 2) - countS) + '#' + new string('~', n - i) + '#' + new string('.', 1 + countS));
                countS = countS + 2;
            }
            Console.WriteLine(new string('.', n * 2 + 1) + new string('#', n - 1) + new string('.', n * 2 - 1));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n * 2 + 2) + new string('#', 2) + new string('.', n * 2 + 2));
            }
        }
    }
}
