using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n = ");
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            for (var i = 0; i < n; i++ )
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }
            var rightSum = 0;
            for (var i = 0; i < n; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }
            if (leftSum == rightSum)
                Console.WriteLine("Yes, sum = " + leftSum);
            else
                Console.WriteLine("No, diff = " + Math.Abs(rightSum - leftSum));

        }
    }
}
