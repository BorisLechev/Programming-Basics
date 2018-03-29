using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuni_Camp
{
    class Program
    {
        static void Main(string[] args) 
        {
            var groups = int.Parse(Console.ReadLine());
            var allPeople = 0;
            var car = 0.0;
            var microbus = 0.0;
            var smallBus = 0.0;
            var bigBus = 0.0;
            var train = 0.0;
            for (int i = 0; i < groups; i++)
            {
                var people = int.Parse(Console.ReadLine());
                allPeople += people;
                if (people > 0 && people <= 5)
                {
                    car += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    microbus += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    smallBus += people;
                }
                else if (people >= 26 && people <= 40)
                {
                    bigBus += people;
                }
                else
                {
                    train += people;
                }
            }
            Console.WriteLine("{0:f2}%", (car / allPeople) * 100);
            Console.WriteLine("{0:f2}%", (microbus / allPeople) * 100);
            Console.WriteLine("{0:f2}%", (smallBus / allPeople) * 100);
            Console.WriteLine("{0:f2}%", (bigBus / allPeople) * 100);
            Console.WriteLine("{0:f2}%", (train / allPeople) * 100);
        }
    }
}
