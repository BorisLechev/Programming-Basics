using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var average = 0.0;
            for (int i = 1; i <= students; i++)
            {
                var num = double.Parse(Console.ReadLine());
                average += num;
                if (num >= 2.00 && num <= 2.99)
                {
                    p1++;
                }
                else if (num >= 3.00 && num <= 3.99)
                {
                    p2++;
                }
                else if (num >= 4.00 && num <= 4.99)
                {
                    p3++;
                }
                else if (num >= 5.00)
                {
                    p4++;
                }
            }
            Console.WriteLine("Top students: {0:f2}%", p4 / students * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", p3 / students * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", p2 / students * 100);
            Console.WriteLine("Fail: {0:f2}%", p1 / students * 100);
            Console.WriteLine("Average: {0:f2}%", average / students);
        }
    }
}
