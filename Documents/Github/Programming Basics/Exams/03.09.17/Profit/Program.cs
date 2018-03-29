using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLeva = int.Parse(Console.ReadLine());
            int twoLeva = int.Parse(Console.ReadLine());
            int fiveLeva = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            int combination = 0;
            for (int num1 = 0; num1 <= oneLeva; num1++)
            {
                for (int num2 = 0; num2 <= twoLeva; num2++)
                {
                    for (int num3 = 0; num3 <= fiveLeva; num3++)
                    {
                        if (num1 * 1 + num2 * 2 + num3 * 5 == sum)
                        {
                            Console.WriteLine($"{num1} * 1 lv. + {num2} * 2 lv. + {num3} * 5 lv. = {sum} lv.");
                            combination++;
                        }
                        
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
