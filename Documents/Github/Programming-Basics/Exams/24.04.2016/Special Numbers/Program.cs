using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= 9; i++)
            {
                for (var j = 1; j <= 9; j++)
                {
                    for (var m = 1; m <= 9; m++)
                    {
                        for (var k = 1; k <= 9; k++)
                        {
                            if (n % i == 0 && n % j == 0 && n % m == 0 && n % k == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", i, j, m, k);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
