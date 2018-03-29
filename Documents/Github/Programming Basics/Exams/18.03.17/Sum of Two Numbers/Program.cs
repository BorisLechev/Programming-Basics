using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args) //!!!!!!!!!!!
        {
            var startInterval = int.Parse(Console.ReadLine());
            var finishInterval = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var counter = 0;
            for (var i = startInterval; i <= finishInterval; i++)
            {
                for (var j = startInterval; j <= finishInterval; j++)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine("Combination N: {0} ({1} + {2} = {3})", counter, i, j, magicNumber);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
        }
    }
}
