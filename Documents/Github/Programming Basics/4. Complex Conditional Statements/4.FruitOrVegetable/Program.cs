using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            if (s == "banana" || s == "apple" || s == "kiwi" || s == "cherry" || s == "lemon" || s == "grapes")
            {
                Console.WriteLine("Fruit");
            }
            else if (s == "tomato" || s == "cucumber" || s == "pepper" || s == "carrot")
            {
                Console.WriteLine("Vegetable");
            }
            else
            {
                Console.WriteLine("Unknown");
            }
        }
    }
}
