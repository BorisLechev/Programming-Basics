using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var confectioners = int.Parse(Console.ReadLine());
            var numCake = int.Parse(Console.ReadLine());
            var numGofreti = int.Parse(Console.ReadLine());
            var numPancakes = int.Parse(Console.ReadLine());
            var cakes = numCake * 45;
            var gofreti = numGofreti * 5.8;
            var pancakes = numPancakes * 3.2;
            var sumforaDay = (cakes + gofreti + pancakes) * confectioners;
            var sum = sumforaDay * days;
            var clearsum = sum - (sum * 1 / 8);
            Console.WriteLine("{0:f2}", clearsum);
        }
    }
}
