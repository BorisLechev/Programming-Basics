using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Award
{
    class Program
    {
        static void Main(string[] args) // ???????????????
        {
            var partedProject = int.Parse(Console.ReadLine());
            var awardforaPoint = double.Parse(Console.ReadLine());
            var sum = 0;
            var TotalPrice = 0.0;
            for (var i = 1; i <= partedProject; i++)
            {
                var points = int.Parse(Console.ReadLine());
                    if (points % 2 == 0)
                    {
                        points = points * 2;
                    }
                    else
                    {
                        points++;
                    }
                    sum += points;
                    TotalPrice = (sum * awardforaPoint);
            }
            Console.WriteLine("The project prize was {0:f2} lv.", TotalPrice);
        }
    }
}
