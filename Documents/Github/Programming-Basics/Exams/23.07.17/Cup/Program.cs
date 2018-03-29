using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cup
{
    class Program
    {
        static void Main(string[] args) // !!!!!!!!!
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n + i), new string('#', n * 3 - (2 * i)));
            }
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', n + n / 2 + i), new string('.', (n * 2 - 2) - (2 * i)));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', (width - n) / 2), new string('#', n));
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (width - (n + 4)) / 2), new string('#', n + 4));
            }
            Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', (width - 10) / 2));
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (width - (n + 4)) / 2), new string('#', n + 4));
            }
        }
    }
}
