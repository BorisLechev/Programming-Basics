using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var needHours = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());
            var day = 8;
            var workHours = workers * workDays * day;
            var leftHours = Math.Abs(workHours - needHours);
            var penalties = leftHours * workDays;
            if (workHours > needHours)
            {
                Console.WriteLine("{0} hours left.", leftHours);
            }
            else if (workHours < needHours)
            {
                Console.WriteLine("{0} overtime", leftHours);
                Console.WriteLine("Penalties: {0}", penalties);
            }
        }
    }
}
