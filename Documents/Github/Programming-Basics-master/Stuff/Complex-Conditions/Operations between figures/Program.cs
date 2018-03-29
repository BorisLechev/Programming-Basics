using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_between_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var operation = char.Parse(Console.ReadLine());
            switch(operation)
            {
                case '+':
                    Console.WriteLine($"{a} + {b} = {a + b} - " + ((a + b) % 2 == 0 ? "even" : "odd"));break;
                case '-':
                    Console.WriteLine($"{a} - {b} = {a - b} - " + ((a - b) % 2 == 0 ? "even" : "odd"));break;
                case '*':
                    Console.WriteLine($"{a} * {b} = {a * b} - " + (( a * b) % 2 == 0 ? "even" : "odd" ));break;
                case '/':
                    if (b == 0)
                        Console.WriteLine($"Cannot divide {a} by zero");
                    else
                        Console.WriteLine($"{a} / {b} = {(double)a / b:F2}");break;
                case '%':
                    if (b == 0)
                        Console.WriteLine($"Cannot divide {a} by zero");
                    else
                    Console.WriteLine($"{a} % {b} = {a % b}");break;
            }
        }
    }
}
