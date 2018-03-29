using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var countOfAsterisk = 1;
            char dash = '-';
            char asterisk = '*';
            if (n % 2 == 0)
                countOfAsterisk = 2;
            int countOfDashes = (n - countOfAsterisk) / 2;
            string topAndBotRow = string.Format("{0}{1}{0}", new string(dash, countOfDashes), new string(asterisk, countOfAsterisk));
            Console.WriteLine(topAndBotRow);

            int totalRows = n;
            if (n % 2 == 0)
            {
                n--;
            }
            int rowsOfTopPart = (totalRows - 1) / 2;
            int countOfMiddlesDashes = countOfAsterisk;
            for (int currentRow = 0; currentRow < rowsOfTopPart; currentRow++)
            {
                countOfDashes--;
                string sideDashes = new string(dash, countOfDashes);
                string middleDashes = new string(dash, countOfMiddlesDashes);
                Console.WriteLine("{0}*{1}*{0}", sideDashes, middleDashes);
                countOfMiddlesDashes += 2;
            }

            int rowsOfBottomPart = rowsOfTopPart - 1;
            countOfMiddlesDashes -= 4;
            for (int currentRow = 1; currentRow <= rowsOfBottomPart; currentRow++)
            {
                string sideDashes = new string(dash, currentRow);
                string middleDashes = new string(dash, countOfMiddlesDashes);
                countOfMiddlesDashes -= 2;
                Console.WriteLine("{0}*{1}*{0}", sideDashes, middleDashes);
            }
            if (n > 2)
            {
                Console.WriteLine(topAndBotRow);
            }
        }
    }
}
