using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            for (int row = 0; row <= size; row++)
            {

                string stars = new string('*', row);
                string leftRight = new string(' ', size - row);

                Console.WriteLine("{0}{1}{2}{1}", leftRight, stars, " | ");
            }
        }
    }
}
