using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Number
{
    class Program
    {
        static void Main(string[] args) //!!!!!!!!!!!!!!
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var controlNum = int.Parse(Console.ReadLine());
            var numCombinations = 0;
            var sumofNumbers = 0;
            bool checkControlNum = false;
            for (var combination1 = 1; combination1 <= firstNum; combination1++)
            {
                for (var combination2 = secondNum; combination2 >= 1; combination2--)
                {
                    numCombinations++;
                    sumofNumbers += combination1 * 2 + combination2 * 3;
                    if (sumofNumbers >= controlNum)
                    {
                        checkControlNum = true; break;
                    }
                }
                if (checkControlNum) break;
            }
            Console.WriteLine("{0} moves", numCombinations);
            if (checkControlNum)
            {
                Console.WriteLine("Score: {0} >= {1}", sumofNumbers, controlNum);
            }
        }
    }
}
