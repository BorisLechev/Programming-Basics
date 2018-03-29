using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());
            var water = months * 20;
            var internet = months * 15;
            var sum = 0.0;
            for (int i = 0; i < months; i++)
            {
                var electricity = double.Parse(Console.ReadLine());
                sum += electricity;
            }
            var other = (sum + water + internet) + (sum + water + internet) * 0.2;
            var average = (sum + water + internet + other) / months;
            Console.WriteLine("Electricity: {0:f2} lv", sum);
            Console.WriteLine("Water: {0:f2} lv", water);
            Console.WriteLine("Internet: {0:f2} lv", internet);
            Console.WriteLine("Other: {0:f2} lv", other);
            Console.WriteLine("Average: {0:f2} lv", average);
        }
    }
}
