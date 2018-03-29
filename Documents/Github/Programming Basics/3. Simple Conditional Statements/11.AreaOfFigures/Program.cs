using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                var area = side * side;
                Console.WriteLine(area);
            }
            else if (figure == "rectangle")
            {
                var side1 = double.Parse(Console.ReadLine());
                var side2 = double.Parse(Console.ReadLine());
                var area = side1 * side2;
                Console.WriteLine("{0:f1}", area);
            }
            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var area = Math.PI * r * r;
                Console.WriteLine("{0:f3}", area);
            }
            else if (figure == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                var area = side * height / 2;
                Console.WriteLine(area);
            }
        }
    }
}
