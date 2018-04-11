using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainingDays = int.Parse(Console.ReadLine());
            var dancers = int.Parse(Console.ReadLine());
            var energy = 0.0;
            var energySum = 100 * dancers * trainingDays;
            for (int i = 0; i < trainingDays; i++)
            {
                var hours = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && hours % 2 == 0)
                    energy += 68;
                else if (i % 2 == 1 && hours % 2 == 0)
                    energy += 49;
                else if (i % 2 == 0 && hours % 2 == 1)
                    energy += 65;
                else if (i % 2 == 1 && hours % 2 == 1)
                    energy += 30;
            }
            var energyLeft = energySum - (energy * dancers);
            var energyLeftPerDancer = energyLeft / dancers / trainingDays;
            if (energyLeftPerDancer <= 50)
            {
                Console.WriteLine("They are wasted! Energy");
                Console.WriteLine("left: {0:f2}", energyLeftPerDancer);
            }
            else
            {
                Console.WriteLine("They feel good! Energy");
                Console.WriteLine("left: {0:f2}", energyLeftPerDancer);
            }
        }
    }
}
