using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args) 
        {
            var n = int.Parse(Console.ReadLine());
            var width = n * 2;
            if (n > 4)
            {
                Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string('_', n / 2));
                for (int i = 0; i < n - 3; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < width - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
                Console.WriteLine("|{0}{1}{0}|", new string(' ', (width - n / 2) / 2 - 1), new string('_', n / 2));
                Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', n / 2));
            }
            else
            {
                Console.WriteLine("/{0}\\/{0}\\", new string('^', n / 2));
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < width - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
                Console.WriteLine("\\{0}/\\{0}/", new string('_', n / 2));
            }
        }
    }
}
