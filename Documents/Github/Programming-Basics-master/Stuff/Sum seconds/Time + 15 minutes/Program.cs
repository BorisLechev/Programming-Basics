using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 15;
            if (minutes > 59)
            {
                hour++;
                    minutes -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, minutes);
            }

        }
    }
}
