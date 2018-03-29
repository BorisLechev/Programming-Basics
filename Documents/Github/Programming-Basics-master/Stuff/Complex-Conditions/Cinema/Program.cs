using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine();
            var r = double.Parse(Console.ReadLine());
            var s = double.Parse(Console.ReadLine());
            if (projection == "Premiere")
                Console.WriteLine(r * s * 12.00);
            else if (projection == "Normal")
                Console.WriteLine(r * s * 7.50);
            else if (projection == "Discount")
                Console.WriteLine(r * s * 5.00);
        }
    }
}
