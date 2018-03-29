using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            var dalginaA = double.Parse(Console.ReadLine());
            var heightB = double.Parse(Console.ReadLine());
            var side1and2rectangle = ((dalginaA * dalginaA) / 2) * 2;
            var square = (dalginaA / 2) * (dalginaA / 2);
            var triangle = ((dalginaA / 2) * (heightB - dalginaA / 2)) / 2;
            var rearWall = square + triangle;
            var entrance = (dalginaA / 5) * (dalginaA / 5);
            var frontWall = rearWall - entrance;
            var areaofSides = side1and2rectangle + rearWall + frontWall;
            var greenPaint = areaofSides / 3;
            var roof = dalginaA * (dalginaA / 2) * 2;
            var redPaint = roof / 5;
            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}
