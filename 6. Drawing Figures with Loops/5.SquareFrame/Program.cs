using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            // Top

            Console.Write("+");

            for (int i = 0; i < size - 2; i++)
            {
                Console.Write(" -");
            }

            Console.Write(" +");
            Console.WriteLine();

            // Middle

            for (int row = 0; row < size - 2; row++)
            {
                Console.Write("|");

                for (int col = 0; col < size - 2; col++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");

            }

            //Bottom

            Console.Write("+");

            for (int i = 0; i < size - 2; i++)
            {
                Console.Write(" -");
            }

            Console.Write(" +");
            Console.WriteLine();
        }
    }
}
