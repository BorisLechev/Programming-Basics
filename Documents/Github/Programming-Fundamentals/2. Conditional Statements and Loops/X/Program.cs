﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int countS = 0;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', i), new string(' ', (n - 2) - 2 * i));
            }
            Console.WriteLine("{0}x{0}", new string(' ', n / 2));
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', (n / 2 - 1) + count), new string(' ', 1 + countS));
                count -= 1;
                countS += 2;
            }
        }
    }
}
