using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var min = double.MaxValue;
            for (var i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < min)
                    min = num;
            }
            Console.WriteLine("min = " + min);
        }
    }
}
