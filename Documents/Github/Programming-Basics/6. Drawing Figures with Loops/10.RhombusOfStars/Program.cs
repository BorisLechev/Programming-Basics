using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string s = new string('s', n).Replace("s", "* ");

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{new string(' ', n - i - 1)}{s.Substring(0, 2 * i + 1)}");

            for (int i = n - 2; i >= 0; i--)
                Console.WriteLine($"{new string(' ', n - i - 1)}{s.Substring(0, 2 * i + 1)}");
        }
    }
}
