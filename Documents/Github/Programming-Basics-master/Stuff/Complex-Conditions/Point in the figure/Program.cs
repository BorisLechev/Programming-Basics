using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            if ((x >= 0 && x <= h * 3 && y >= 0 && y <= h) || (x >= h && x <= h * 2 && y >= h && y <= h * 4))
            {
                if ((x >= 0 && x < h * 3 && y > 0 && y < h) || (x > h && x < h * 2 && y > h && y < h * 4))
                    Console.WriteLine("Inside");
                else
                {
                    if (x > h && x < h * 2 && y == h)
                        Console.WriteLine("Inside");
                    else
                        Console.WriteLine("border");
                }
            }
            else
                Console.WriteLine("outside");
            }
        }
    }

