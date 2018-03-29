using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            if (figure == "square")
            {
                var num1 = double.Parse(Console.ReadLine());
                var square = Math.Round(num1 * num1,3);
                Console.WriteLine(square);
            }
            else if (figure == "rectangle")
            {
                var num1 = double.Parse(Console.ReadLine());
                var num2 = double.Parse(Console.ReadLine());
                var rectangle = Math.Round(num1 * num2,3);
                Console.WriteLine(rectangle);
            }
            else if (figure == "circle")
            {
                var num1 = double.Parse(Console.ReadLine());
                var circle = Math.Round(Math.PI * num1 * num1,3);
                Console.WriteLine(circle);
            }
            else if (figure == "triangle")
            {
                var num1 = double.Parse(Console.ReadLine());
                var num2 = double.Parse(Console.ReadLine());
                var triangle = Math.Round(num1 * num2 / 2,3);
                Console.WriteLine(triangle);
            }
        }
    }
}
