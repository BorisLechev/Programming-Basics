using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_between_Numbers_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var symbol = Console.ReadLine();
            var sum = n1 + n2;
            var divide = n1 / n2;
            var umnogenie = n1 * n2;
            var subtract = n1 - n2;
            var delenie = n1 % n2;
            if (symbol == "+")
            {
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even", n1, n2, sum);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, sum);
                }
            }
            else if (symbol == "-")
            {
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", n1, n2, subtract);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, subtract);
                }
            }
            else if (symbol == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    Console.WriteLine("{0} / {1} = {2}", n1, n2, divide);
                }
            }
            else if (symbol == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    Console.WriteLine("{0} / {1} = {2}", n1, n2, delenie);
                }
            }
            else if (symbol == "*")
            {
                if (umnogenie % 2 != 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, umnogenie);
                }
            }
        }
    }
}
