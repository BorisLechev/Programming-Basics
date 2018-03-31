using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayer = int.Parse(Console.ReadLine());
            var secondPlayer = int.Parse(Console.ReadLine());
            var maxBattles = int.Parse(Console.ReadLine());
            var battlesCount = 0;
            for (int first = 1; first <= firstPlayer; first++)
            {
                for (int second = 1; second <= secondPlayer; second++)
                {
                    if (battlesCount == maxBattles)
                    {
                        Console.WriteLine(); return;
                    }
                    else
                    {
                        Console.Write("({0} <-> {1})", first, second);
                    }
                    battlesCount++;
                }
            }
            Console.WriteLine();
        }
    }
}
