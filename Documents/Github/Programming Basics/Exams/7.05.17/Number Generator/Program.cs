using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var M = int.Parse(Console.ReadLine());
            var N = int.Parse(Console.ReadLine());
            var L = int.Parse(Console.ReadLine());
            var special = int.Parse(Console.ReadLine());
            var control = int.Parse(Console.ReadLine());
            for (var i = M; i >= 1; i--)
            {
                for (var j = N; j >= 1; j--)
                {
                    for (var k = L; k >= 1; k--)
                    {
                        var num = 100 * i + 10 * j + k;
                        if (num % 3 == 0)
                        {
                            special += 5;
                        }
                        else if (num % 5 == 0)
                        {
                            special -= 2;
                        }
                        else if (num % 2 == 0)
                        {
                            special *= 2;
                        }
                        if (special >= control)
                        {
                            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", special); return;
                        }
                    }
                }
            }
            if (special < control)
            {
                Console.WriteLine("No! {0} is the last reached special number.", special);
            }
        }
    }
}
