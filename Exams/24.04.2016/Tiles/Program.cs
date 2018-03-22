using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var o = int.Parse(Console.ReadLine());
            var area = n * n;
            var areaOfBench = m * o;
            var areaForCover = area - areaOfBench;
            var tilesArea = w * l;
            var needTiles = areaForCover / tilesArea;
            var needTime = needTiles * 0.2;
            Console.WriteLine(needTiles);
            Console.WriteLine(needTime);
        }
    }
}
