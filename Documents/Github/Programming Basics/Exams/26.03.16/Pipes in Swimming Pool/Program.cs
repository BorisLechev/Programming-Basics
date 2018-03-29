using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes_in_Swimming_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            var volume = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var p1water = p1 * h;
            var p2water = p2 * h;
            var water = p1water + p2water;
            if (water <= volume)
            {
                var full = water / volume * 100;
                var p1Percent = Math.Floor(p1water / water * 100);
                var p2Percent = Math.Floor(p2water / water * 100);
                Console.WriteLine("The pool is {0:f2}% full. Pipe 1: {1:f2}%. Pipe 2: {2:f2}%.", full, p1Percent, p2Percent);
            }
            else
            {
                var full = water - volume;
                Console.WriteLine("For {0:f2} hours the pool overflows with {1} liters.", h, full);
            }
        }
    }
}
