using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Number_1
{
    class Program
    {
        static void Main(string[] args) // !!!!!!!
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int ctrlNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            for (int first = 1; first <= n; first++)
            {
                for (int second = m; second >= 1; second--)
                {
                    counter++;
                    sum += first * 2 + second * 3;
                    if (sum >= ctrlNumber)
                    {
                        Console.WriteLine($"{counter} moves Score: {sum} >= {ctrlNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} moves");
        }
    }
}
