using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstDigit = n / 100;
            int secondDigit = n / 10 % 10;
            int thirdDigit = n % 10;

            int rows = firstDigit + secondDigit;
            int cols = firstDigit + thirdDigit;

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstDigit;
                        Console.Write($"{n} ");
                    }
                    else if (n % 3 == 0)
                    {
                        n -= secondDigit;
                        Console.Write($"{n} ");
                    }
                    else
                    {
                        n += thirdDigit;
                        Console.Write($"{n} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
