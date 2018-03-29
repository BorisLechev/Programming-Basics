using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var studioPrice = 0.0;
            var flatPrice = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    flatPrice = 65;
                    if (nights > 14)
                    {
                        studioPrice -= 50 * 0.3;
                        flatPrice -= 65 * 0.1;
                    }
                    else if (nights > 7)
                    {
                        studioPrice -= 50 * 0.05;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.2;
                    flatPrice = 68.7;
                    if (nights > 14)
                    {
                        studioPrice -= 75.2 * 0.2;
                        flatPrice -= 68.7 * 0.1;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    flatPrice = 77;
                    if (nights > 14)
                    {
                        flatPrice -= 77 * 0.1;
                    }
                    break;
            }
            var totalstudioPrice = studioPrice * nights;
            var totalflatPrice = flatPrice * nights;
            Console.WriteLine("Apartment: {0:f2} lv.", totalflatPrice);
            Console.WriteLine("Studio: {0:f2} lv.", totalstudioPrice);
        }
    }
}
