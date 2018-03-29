using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', size * 2) +
                                        new string(' ', size) +
                                        new string('*', size * 2));
            for (int row = 0; row < size - 2; row++)
            {
                string glass = (new string('*', 1) + (new string('/', size * 2 - 2) + "*"));

                string middle;

                if (row == (size - 1) / 2 - 1)
                {
                    middle = new string('|', size);
                }
                else
                {
                    middle = new string(' ', size);
                }

                Console.WriteLine(glass + middle + glass);
            }

            Console.WriteLine(new string('*', size * 2) +
                new string(' ', size) +
                new string('*', size * 2));
        }
    }
}
