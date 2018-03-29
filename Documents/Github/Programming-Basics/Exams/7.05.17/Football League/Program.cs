using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacity = double.Parse(Console.ReadLine());
            var fensNumber = double.Parse(Console.ReadLine());
            var numA = 0.0;
            var numB = 0.0;
            var numV = 0.0;
            var numG = 0.0;
            for (var i = 1; i <= fensNumber; i++)
            {
                var sector = Console.ReadLine();
                if (sector == "A") numA++;
                else if (sector == "B") numB++;
                else if (sector == "V") numV++;
                else if (sector == "G") numG++;
            }
            Console.WriteLine("{0:f2}%", (numA / fensNumber) * 100);
            Console.WriteLine("{0:f2}%", (numB / fensNumber) * 100);
            Console.WriteLine("{0:f2}%", (numV / fensNumber) * 100);
            Console.WriteLine("{0:f2}%", (numG / fensNumber) * 100);
            Console.WriteLine("{0:f2}%", (fensNumber / capacity) * 100);
        }
    }
}
