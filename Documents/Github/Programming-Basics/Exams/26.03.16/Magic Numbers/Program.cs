using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Numbers
{
    class Program
    {
        static void Main(string[] args) //!!!!!
        {
            int magicNumber = int.Parse(Console.ReadLine());
            for (int first = 1; first < 10; first++)
            {
                for (int second = 1; second < 10; second++)
                {
                    for (int third = 1; third < 10; third++)
                    {
                        for (int fourth = 1; fourth < 10; fourth++)
                        {
                            for (int fifth = 1; fifth < 10; fifth++)
                            {
                                for (int sixth = 1; sixth < 10; sixth++)
                                {
                                    if ((first * second * third * fourth * fifth * sixth) == magicNumber)
                                    {
                                        Console.Write($"{first}{second}{third}{fourth}{fifth}{sixth} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
