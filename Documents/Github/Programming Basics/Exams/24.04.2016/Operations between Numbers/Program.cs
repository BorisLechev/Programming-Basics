using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double result = 0.0;
            if (symbol == "+")
            {
                result = n1 + n2;
                string status = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{n1} + {n2} = {result} - {status}");
            }
            else if (symbol == "-")
            {
                result = n1 - n2;
                string status = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{n1} - {n2} = {result} - {status}");
            }
            else if (symbol == "*")
            {
                result = n1 * n2;
                string status = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{n1} * {n2} = {result} - {status}");
            }
            else if (symbol == "/")
            {
                if (n2 == 0 || n1 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    result = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
            }
            else if (symbol == "%")
            {
                if (n2 == 0 || n1 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                result = n1 % n2;
                Console.WriteLine($"{n1} % {n2} = {result}");
            }
        }
    }
}
