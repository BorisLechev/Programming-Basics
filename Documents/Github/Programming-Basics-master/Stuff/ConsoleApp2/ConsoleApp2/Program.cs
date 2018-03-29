using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', number));
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("*");
                for (int a = 0; a < number - 2; a++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*', number));
        }
    }
}
