using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoded_Answers
{
    class Program
    {
        static void Main(string[] args) // ????
        {
            var n = int.Parse(Console.ReadLine());
            string result = null;
            var countA = 0;
            var countB = 0;
            var countC = 0;
            var countD = 0;
            for (int i = 0; i < n; i++)
            {
                uint answerAsNumber = uint.Parse(Console.ReadLine());
                string answer;

                if (answerAsNumber % 4 == 0)
                {
                    answer = "a";
                    countA++;
                }
                else if (answerAsNumber % 4 == 1)
                {
                    answer = "b";
                    countB++;
                }
                else if (answerAsNumber % 4 == 2)
                {
                    answer = "c";
                    countC++;
                }
                else if (answerAsNumber % 4 == 3)
                {
                    answer = "d";
                    countD++;
                }
                result = answer + ' ';
            }
            Console.WriteLine(result);
            Console.WriteLine("Answer A: {0}\nAnswer B: {1}\nAnswer C: {2}\nAnswer D: {3}", countA, countB, countC, countD);
        }
    }
}
