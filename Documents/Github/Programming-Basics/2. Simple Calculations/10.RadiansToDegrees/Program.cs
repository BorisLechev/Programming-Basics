using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("radians = ");
            var radians = double.Parse(Console.ReadLine());
            var degrees = Math.Round(radians / (Math.PI / 180));
            Console.Write("degrees = ");
            Console.WriteLine(degrees);
        }
    }
}
