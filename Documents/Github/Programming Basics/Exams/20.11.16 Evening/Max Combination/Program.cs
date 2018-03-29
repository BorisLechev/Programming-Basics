using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Combination
{
    class Program
    {
        static void Main(string[] args) 
        {
            var startInterval = int.Parse(Console.ReadLine());
            var finishInterval = int.Parse(Console.ReadLine());
            var maxCombinations = int.Parse(Console.ReadLine());
            var combinationsCount = 0;
            for (int num1 = startInterval; num1 <= finishInterval; num1++)
            {
                for (int num2 = startInterval; num2 <= finishInterval; num2++)
                {
                    if (combinationsCount == maxCombinations)
                    {
                        Console.WriteLine(); return;
                    }
                    else
                    {
                        Console.Write("<{0} - {1}>", num1, num2);
                    }
                    combinationsCount++;
                }
            }
            Console.WriteLine();
        }
    }
}
