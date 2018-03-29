using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Element_equal_to_sum_of_the_others
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var num = 0;
            var max = int.MinValue;
            for (var i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                sum += num;
            }
            sum = sum - max;
            if (sum == max)
                Console.WriteLine("Yes sum = " + sum);
            else
                Console.WriteLine("No Diff = " + Math.Abs(sum - max));

        }
    }
}
