using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionDays
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            var purchases = 0;
            while (command != "mall.Enter")
            {
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "mall.Exit")
            {
                string actions = command;

            }
        }
    }
}
