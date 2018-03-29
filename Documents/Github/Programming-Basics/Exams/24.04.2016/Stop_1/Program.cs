using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var h = (n * 2) + 2;
            var w = (n * 2) + (2 * n - 1) - 4;
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1));
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', n - i), new string('_', (2 * n - 1) + i + i));
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', w / 2));
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', i), new string('_', w + 4 - i - i));
            }
        }
    }
}
