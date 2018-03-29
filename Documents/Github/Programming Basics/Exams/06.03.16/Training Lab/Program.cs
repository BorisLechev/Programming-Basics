using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = Math.Floor((double.Parse(Console.ReadLine()) * 100));
            var h = Math.Floor((double.Parse(Console.ReadLine()) * 100));
            var corridor = 0.1 * 1000;
            var hall = h - corridor;
            var bureaus = Math.Floor(hall / 70);
            var rows = Math.Floor(w / 120);
            var seets = rows * bureaus - 3;
            Console.WriteLine(seets);
        }
    }
}
