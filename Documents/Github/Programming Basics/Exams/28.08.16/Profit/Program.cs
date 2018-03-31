using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var workDays = int.Parse(Console.ReadLine());
            var moneyEarnedforaDay = double.Parse(Console.ReadLine());
            var dollarRate = double.Parse(Console.ReadLine());
            var monthlySalary = workDays * moneyEarnedforaDay;
            var annualSalary = monthlySalary * 12 + monthlySalary * 2.5;
            var tax = annualSalary - annualSalary * 0.25;
            var clearannualIncome = tax * dollarRate;
            var averageProfit = clearannualIncome / 365;
            Console.WriteLine("{0:f2}", averageProfit);
        }
    }
}
