using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsNumber = int.Parse(Console.ReadLine());
            int seniorsNumber = int.Parse(Console.ReadLine());
            int people = juniorsNumber + seniorsNumber;
            string trace = Console.ReadLine();
            double juniors = 0.0;
            double seniors = 0.0;
            double price = 0.0;
            switch (trace)
            {
                case "trail":
                    juniors = 5.5;
                    seniors = 7;
                    price = juniorsNumber * juniors + seniorsNumber * seniors;
                    break;
                case "cross-country":
                    juniors = 8;
                    seniors = 9.5;
                    price = juniorsNumber * juniors + seniorsNumber * seniors;
                    if (people >= 50)
                    {
                        price = price - price * 0.25;
                    }
                    break;
                case "downhill":
                    juniors = 12.25;
                    seniors = 13.75;
                    price = juniorsNumber * juniors + seniorsNumber * seniors;
                    break;
                case "road":
                    juniors = 20;
                    seniors = 21.5;
                    price = juniorsNumber * juniors + seniorsNumber * seniors;
                    break;
            }
            double expenditures = price * 0.05;
            double result = price - expenditures;
            Console.WriteLine("{0:f2}", result);
        }
    }
}
