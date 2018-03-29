using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSpeed = int.Parse(Console.ReadLine());
            var firstTime = double.Parse(Console.ReadLine()) / 60;
            var secondTime = double.Parse(Console.ReadLine()) / 60;
            var thirdTime = double.Parse(Console.ReadLine()) / 60;
            var firstKm = firstSpeed + firstSpeed * 0.1;
            var first = firstSpeed * firstTime;
            var secondSpeed = (firstSpeed + firstSpeed * 0.1) * secondTime;
            var thirdSpeed = (firstKm - firstKm * 0.05) * thirdTime;
            var sum = first + secondSpeed + thirdSpeed;
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
