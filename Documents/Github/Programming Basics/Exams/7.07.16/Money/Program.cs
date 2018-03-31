using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args) 
        {
            int bitcoinsNumber = int.Parse(Console.ReadLine());
            double yuansNumber = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());
            int bitcoin = 1168 * bitcoinsNumber;
            double yuans = yuansNumber * 0.15;
            double dollars = yuans * 1.76;
            double euros = (bitcoin + dollars) / 1.95;
            double result = euros - euros * commision / 100;
            Console.WriteLine(result);
        }
    }
}
