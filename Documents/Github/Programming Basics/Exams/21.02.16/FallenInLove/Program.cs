using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var symbol = '#';
            var leafSpace = 0;
            var insideSpace = 2 * n;
            var middleSpace = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", symbol, new string('~', leafSpace), new string('.', insideSpace), new string('.', middleSpace));
                leafSpace++;
                insideSpace -= 2;
                middleSpace += 2;
            }
            var outsideSpace = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.', outsideSpace), symbol, new string('~', leafSpace), new string('.', middleSpace));
                outsideSpace += 2;
                leafSpace -= 1;
                middleSpace -= 2;
            }
            Console.WriteLine("{0}{1}{1}{1}{1}{0}", new string('.', 2 * n + 1), symbol);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{1}{0}", new string('.', 2 * n + 2), symbol);
            }
        }
    }
}
