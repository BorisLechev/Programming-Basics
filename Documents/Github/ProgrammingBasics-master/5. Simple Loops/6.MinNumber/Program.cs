﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
                if (i == 0)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}