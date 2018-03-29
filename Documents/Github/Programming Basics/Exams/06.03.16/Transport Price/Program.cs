using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string travel = Console.ReadLine();
            double startFee = 0.0;
            double dayRate = 0.0;
            double nightRate = 0.0;
            double check = 0.0;
            if (distance < 20)
            {
                if (travel == "day")
                {
                    startFee = 0.7;
                    dayRate = 0.79;
                    check = startFee + distance * dayRate;
                    Console.WriteLine(check);
                }
                else if (travel == "night")
                {
                    startFee = 0.7;
                    nightRate = 0.9;
                    check = startFee + distance * nightRate;
                    Console.WriteLine(check);
                }
            }
            else if (distance > 20 && distance < 100)
            {
                if (travel == "day")
                {
                    dayRate = 0.09;
                    check = dayRate * distance;
                    Console.WriteLine(check);
                }
                else if (travel == "night")
                {
                    nightRate = 0.09;
                    check = nightRate * distance;
                    Console.WriteLine(check);
                }
            }
            else if (distance > 100)
            {
                if (travel == "day")
                {
                    dayRate = 0.06;
                    check = dayRate * distance;
                    Console.WriteLine(check);
                }
                else if (travel == "night")
                {
                    nightRate = 0.06;
                    check = nightRate * distance;
                    Console.WriteLine(check);
                }
            }
        }
    }
}
