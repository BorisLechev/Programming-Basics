using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double BGN = double.Parse(Console.ReadLine());
            double USD = BGN * 1.79549;
            Console.WriteLine(Math.Round(USD, 2));
        }
    }
}
