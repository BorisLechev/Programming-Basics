using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRead = 0;
            while (true)
            {
                numberRead = int.Parse(Console.ReadLine());
                if (numberRead % 2 == 0)
                {
                    break;
                }
                Console.WriteLine("Invalid number!");
            }
            Console.WriteLine(numberRead);
        }
    }
}
