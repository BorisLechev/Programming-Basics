using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divicing 
{
    class Program
    {
        static void Main(string[] args) 
        {
            var count = int.Parse(Console.ReadLine());
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            for (var i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    p2++;
                }
                if (number % 3 == 0)
                {
                    p3++;
                }
                if (number % 4 == 0)
                {
                    p4++;
                }
            }
            Console.WriteLine("{0:f2}%", p2 / count * 100);
            Console.WriteLine("{0:f2}%", p3 / count * 100);
            Console.WriteLine("{0:f2}%", p4 / count * 100);
        }
    }
}
