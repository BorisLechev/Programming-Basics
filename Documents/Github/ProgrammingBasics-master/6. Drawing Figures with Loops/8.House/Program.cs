using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countOfMiddleSymbols = 1;
            char dashes = '-';
            char asterisk = '*';
            char pipe = '|';
            if (size % 2 == 0)
            {
                countOfMiddleSymbols = 2;
            }
            int countOfDashes = (size - countOfMiddleSymbols) / 2;
            string rowToFormat = "{0}{1}{0}";
            int rowsOfRoof = (size + 1) / 2;
            for (int currentRow = 0; currentRow < rowsOfRoof; currentRow++)
            {
                string formattedRow = string.Format(rowToFormat, new string(dashes, countOfDashes), new string(asterisk, countOfMiddleSymbols));
                countOfDashes--;
                countOfMiddleSymbols += 2;
                Console.WriteLine(formattedRow);
            }
            int rowsOfBody = size / 2;
            for (int currentRow = 0; currentRow < rowsOfBody; currentRow++)
            {
                string formattedRow = string.Format(rowToFormat, pipe, new string(asterisk, size - 2));
                Console.WriteLine(formattedRow);
            }
        }
    }
}
