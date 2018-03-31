using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            var heightofHouse = double.Parse(Console.ReadLine());
            var dalginaStranichnaStena = double.Parse(Console.ReadLine());
            var heightofRoof = double.Parse(Console.ReadLine());
            var stranichnaStena = heightofHouse * dalginaStranichnaStena;
            var areaWindow = 1.5 * 1.5;
            var bothWalls = (2 * stranichnaStena) - (2 * areaWindow);
            var rearWall = heightofHouse * heightofHouse;
            var entrance = 1.2 * 2;
            var sumFrontRear = 2 * rearWall - entrance;
            var allArea = bothWalls + sumFrontRear;
            var greenPaint = allArea / 3.4;
            var twoRectangles = 2 * (heightofHouse * dalginaStranichnaStena);
            var twoTriangles = 2 * (heightofHouse * heightofRoof / 2);
            var areaRoof = twoRectangles + twoTriangles;
            var redPaint = areaRoof / 4.3;
            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}
