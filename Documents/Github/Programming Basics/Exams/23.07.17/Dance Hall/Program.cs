using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double sideA = double.Parse(Console.ReadLine());
            double areaOfHall = length * 100 * width * 100;
            double areaOfBench = areaOfHall / 10;
            double wardrobe = sideA * 100 * sideA * 100;
            double freeSpace = areaOfHall - wardrobe - areaOfBench;
            double dancers = Math.Floor(freeSpace / (40 + 7000));
            Console.WriteLine(dancers);
        }
    }
}
