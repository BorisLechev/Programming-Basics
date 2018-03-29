using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hungry_Garfield
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var exchangeRate = double.Parse(Console.ReadLine());
            var pizzaPrice = double.Parse(Console.ReadLine());
            var lasagnaPrice = int.Parse(Console.ReadLine());
            var sandwichPrice = int.Parse(Console.ReadLine());
            var pizzaQuantity = int.Parse(Console.ReadLine());
            var lasagnaQuantity = int.Parse(Console.ReadLine());
            var sandwichQuantity = int.Parse(Console.ReadLine());
            var sum = pizzaPrice / exchangeRate * pizzaQuantity + lasagnaPrice / exchangeRate * lasagnaQuantity + sandwichPrice / exchangeRate * sandwichQuantity;
            var result = Math.Abs(money - sum);
            if (money > sum)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", result);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", result);
            }
        }
    }
}
