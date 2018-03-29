using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var evenSum = 0.0;
            var oddMax = double.MinValue;
            var evenMax = double.MinValue;
            var oddMin = double.MaxValue;
            var evenMin = double.MaxValue;
            for (var i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    if (num > evenMax)
                        evenMax = num;
                    else if (num < evenMin)
                        evenMin = num;
                    evenSum += num;
                }
                else
                {
                    if (num > oddMax)
                        oddMax = num;
                    else if (num < oddMin)
                        oddMin = num;
                    oddSum += num;
                }
                
            }
            Console.WriteLine("oddSum = {0}", oddSum);
            if (oddMin == double.MaxValue)
                Console.WriteLine("oddMin = No");
            else
                Console.WriteLine("oddMin = {0}", oddMin);
            if (oddMax == double.MinValue)
                Console.WriteLine("oddMax = No");
            else
                Console.WriteLine("oddMax = {0}", oddMax);
            Console.WriteLine("EvenSum = {0}", evenSum);
            if (evenMin == double.MaxValue)
                Console.WriteLine("EvenMin = No");
            else
                Console.WriteLine("EvenMin = {0}", evenMin);
            if (evenMax == double.MinValue)
                Console.WriteLine("EvenMax = No");
            else
                Console.WriteLine("EvenMax = {0}", evenMax);
        }
    }
}
