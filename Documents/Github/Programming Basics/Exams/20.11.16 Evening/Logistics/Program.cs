using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args) 
        {
            var countofLoads = int.Parse(Console.ReadLine());
            var microbus = 0.0;
            var truck = 0.0;
            var train = 0.0;
            for (var i = 1; i <= countofLoads; i++)
            {
                var tones = int.Parse(Console.ReadLine());
                if (tones <= 3)
                {
                    microbus += tones;
                }
                else if (tones > 4 && tones <= 11)
                {
                    truck += tones;
                }
                else if (tones > 12)
                {
                    train += tones;
                }
            }
            var microbusPrice = microbus * 200.0;
            var truckPrice = truck * 175.0;
            var trainPrice = train * 120.0;
            var totalPrice = microbusPrice + truckPrice + trainPrice;
            var sumtones = microbus + truck + train;
            Console.WriteLine("{0:f2}", totalPrice / sumtones);
            Console.WriteLine("{0:f2}%", (microbus / sumtones) * 100);
            Console.WriteLine("{0:f2}%", (truck / sumtones) * 100);
            Console.WriteLine("{0:f2}%", (train / sumtones) * 100);
        }
    }
}
