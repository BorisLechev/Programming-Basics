using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter $ = ");
            var dollars = double.Parse(Console.ReadLine());
            var lv = dollars * 1.79549;
            Console.WriteLine("Bg Lev = "+ Math.Round(lv, 2));
        }
    }
}
