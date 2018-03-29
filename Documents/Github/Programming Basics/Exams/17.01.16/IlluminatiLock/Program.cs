using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlluminatiLock
{
    class Program
    {
        static void Main(string[] args) // !!!!!!!!!!!!
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
            for (int i = 1; i <= n / 2; i++)
            {

                var edgeSpace = n - 2 * i;
                var middleSpace = n - 2;
                var sideSpace = (3 * n - 2 * edgeSpace - middleSpace - 6) / 2;
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', edgeSpace), new string('.', sideSpace), new string('.', middleSpace));
            }
            for (int i = n / 2; i > 0; i--)
            {
                var edgeSpace = n - 2 * i;
                var middleSpace = n - 2;
                var sideSpace = (3 * n - (2 * edgeSpace) - middleSpace - 6) / 2;
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', edgeSpace), new string('.', sideSpace), new string('.', middleSpace));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
        }
    }
}
