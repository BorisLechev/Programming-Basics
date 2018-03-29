using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var areaHouse = double.Parse(Console.ReadLine());
            var numberWindows = int.Parse(Console.ReadLine());
            var m2inPacket = double.Parse(Console.ReadLine());
            var pricePacket = double.Parse(Console.ReadLine());
            var withoutWindows = (areaHouse - numberWindows * 2.4) + (areaHouse - numberWindows * 2.4) * 0.1;
            var needPackets = Math.Ceiling((withoutWindows / m2inPacket)) * pricePacket;
            var left = Math.Abs(budget - needPackets);
            if (needPackets > budget)
            {
                Console.WriteLine("Need more: {0:f2}", left); return;
            }
            Console.WriteLine("Spent: {0:f2}", needPackets);
            Console.WriteLine("Left: {0:f2}", left);
        }
    }
}
