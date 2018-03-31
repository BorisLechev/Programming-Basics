using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Driver_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmForMonth = double.Parse(Console.ReadLine());
            double feeForKm = 0.0;
            int months = 4;
            if (season == "Spring" || season == "Autumn")
            {
                if (kmForMonth <= 5000)
                {
                    feeForKm = 0.75;
                    double salary = (kmForMonth * feeForKm * months) - (kmForMonth * feeForKm * months) * 0.1;
                    Console.WriteLine("{0:f2}", salary);
                }
                else if (kmForMonth > 5000 && kmForMonth <= 10000)
                {
                    feeForKm = 0.95;
                    double salary = (kmForMonth * feeForKm * months) - (kmForMonth * feeForKm * months) * 0.1;
                    Console.WriteLine("{0:f2}", salary);
                }
            }
            else if (season == "Summer")
            {
                if (kmForMonth <= 5000)
                {
                    feeForKm = 0.9;
                    double salary = (kmForMonth * feeForKm * months) - (kmForMonth * feeForKm * months) * 0.1;
                    Console.WriteLine("{0:f2}", salary);
                }
                else if (kmForMonth > 5000 && kmForMonth <= 10000)
                {
                    feeForKm = 1.1;
                    double salary = (kmForMonth * feeForKm * months) - (kmForMonth * feeForKm * months) * 0.1;
                    Console.WriteLine("{0:f2}", salary);
                }
            }
            else if (season == "Winter")
            {
                if (kmForMonth <= 5000)
                {
                    feeForKm = 1.05;
                    double salary = (kmForMonth * feeForKm * months) - (kmForMonth * feeForKm * months) * 0.1;
                    Console.WriteLine("{0:f2}", salary);
                }
                else if (kmForMonth > 5000 && kmForMonth <= 10000)
                {
                    feeForKm = 1.25;
                    double salary = (kmForMonth * feeForKm * months) - (kmForMonth * feeForKm * months) * 0.1;
                    Console.WriteLine("{0:f2}", salary);
                }
            }
            if (kmForMonth > 10000 && kmForMonth <= 20000)
            {
                feeForKm = 1.45;
                double salary = (kmForMonth * feeForKm * months) - (kmForMonth * feeForKm * months) * 0.1;
                Console.WriteLine("{0:f2}", salary);
            }
        }
    }
}
