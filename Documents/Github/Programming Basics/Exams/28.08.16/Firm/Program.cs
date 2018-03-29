using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var needHours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var employees = int.Parse(Console.ReadLine());
            var emergencyHours = 2;
            var realHours = (days - days * 0.1) * 8;
            var employeesEmergency = employees * emergencyHours * days;
            var sumHours = Math.Floor(employeesEmergency + realHours);
            var project = Math.Abs(sumHours - needHours);
            if (sumHours >= needHours)
            {
                Console.WriteLine("Yes! {0} hours left.", project);
            }
            else
            {
                Console.WriteLine("Not enough time! {0} hours needed.", project);
            }
        }
    }
}
