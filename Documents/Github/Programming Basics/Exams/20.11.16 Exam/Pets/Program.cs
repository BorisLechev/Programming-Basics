using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var allFood = int.Parse(Console.ReadLine());
            var dogFood = double.Parse(Console.ReadLine());
            var catFood = double.Parse(Console.ReadLine());
            var turtleFood = double.Parse(Console.ReadLine()) / 1000;
            var food = (dogFood + catFood + turtleFood) * days;
            if (food < allFood)
            {
                var left = Math.Floor(allFood - food);
                Console.WriteLine("{0} kilos of food left.", left);
            }
            else
            {
                var needFood = Math.Ceiling(food - allFood);
                Console.WriteLine("{0} more kilos of food are needed.", needFood);
            }
        }
    }
}
