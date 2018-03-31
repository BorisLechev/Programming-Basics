using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamand
{
    class Program
    {
        static void Main(string[] args) 
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n * 3));
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - 1 - i), new string('.', n * 3 + 2 * i));
            }
            Console.WriteLine(new string('*', 5 * n));
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', 1 + i), new string('.', n * 5 - 4 - (2 * i)));
            }
        }
    }
}
