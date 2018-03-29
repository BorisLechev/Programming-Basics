using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceVegetable = double.Parse(Console.ReadLine());
            var priceFruit = double.Parse(Console.ReadLine());
            var kgVegetable = int.Parse(Console.ReadLine());
            var kgFruit = int.Parse(Console.ReadLine());
            var vegetables = priceVegetable * kgVegetable;
            var fruits = priceFruit * kgFruit;
            var result = (vegetables + fruits) / 1.94;
            Console.WriteLine(result);
        }
    }
}
