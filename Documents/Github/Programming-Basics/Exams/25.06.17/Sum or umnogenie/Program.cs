using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_or_umnogenie
{
    class Program
    {
        static void Main(string[] args) // !!!!!!
        {
            var sum = int.Parse(Console.ReadLine());
            int flag = 0;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a < b && b < c && a + b + c == sum)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {sum}");
                            flag = 1;
                        }
                        if (a > b && b > c && a * b * c == sum)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {sum}");
                            flag = 1;
                        }
                    }
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
