using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args) // !!!!!!
        {
            var n = int.Parse(Console.ReadLine());
            var width = 12 * n - 5;
            var count = 0;
            var countS = 0;
            var countT = 0;
            var countD = 0;
            var dotsLeft = n * 3 - 4;
            var dotsRight = dotsLeft + 1;
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (width - 1) / 2 + count), new string('#', 1 + countS));
                count -= 3;
                countS += 6;
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', 2 + countT), new string('#', width - 6 + countD), new string('.', 3 + countT));
                countT += 3;
                countD -= 6;
            }
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', dotsLeft), new string('#', width - dotsLeft - dotsRight - 1), new string('.', dotsRight));
            }
            Console.WriteLine("@{0}{1}{2}", new string('.', dotsLeft), new string('#', width - dotsLeft - dotsRight - 1), new string('.', dotsRight));
        }
    }
}
