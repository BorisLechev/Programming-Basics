using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var previousPair = 0;
            var currentPair = 0;
            var difference = 0;
            var maxDifference = 0;
            for (int i = 0; i < n; i++)
            {
                var firstNumber = int.Parse(Console.ReadLine());
                var secondNumber = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    previousPair = firstNumber + secondNumber;
                }
                else
                {
                    currentPair = firstNumber + secondNumber;
                    difference = Math.Abs(currentPair - previousPair);
                    if (difference > maxDifference)
                    {
                        maxDifference = difference;
                    }
                    previousPair = currentPair;
                }
            }
            if (maxDifference == 0)
                Console.WriteLine("Yes, value={0}", previousPair);
            else
                Console.WriteLine("No, maxdiff={0}", maxDifference);
        }
    }
}
