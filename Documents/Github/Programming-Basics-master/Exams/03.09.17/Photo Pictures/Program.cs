using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesNumber = int.Parse(Console.ReadLine());
            string pictures = Console.ReadLine();
            string order = Console.ReadLine();
            double price1 = 0.16 * picturesNumber;
            double price2 = 0.16 * picturesNumber;
            double price3 = 0.38 * picturesNumber;
            double price4 = 2.9 * picturesNumber;
            switch(pictures)
            {
                case "9X13":
                    if (picturesNumber >= 50)
                    {
                        price1 = price1 - (price1 * 0.05);
                    }
                    if (order == "online")
                    {
                        price1 = price1 - (price1 * 0.02);
                        Console.WriteLine("{0:f2}BGN", price1);
                    }
                    else if (order == "office")
                    {
                        Console.WriteLine("{0:f2}BGN", price1);
                    }
                    break;
                case "10X15":
                    if (picturesNumber >= 80)
                    {
                        price2 = price2 - (price2 * 0.03);
                    }
                    if (order == "online")
                    {
                        price2 = price2 - (price2 * 0.02);
                        Console.WriteLine("{0:f2}BGN", price2);
                    }
                    else if (order == "office")
                    {
                        Console.WriteLine("{0:f2}BGN", price2);
                    }
                    break;
                case "13X18":
                    if (picturesNumber >= 50 && picturesNumber <= 100)
                    {
                        price3 = price3 - (price3 * 0.03);
                    }
                    else if (picturesNumber > 100)
                    {
                        price3 = price3 - (price3 * 0.05);
                    }
                    if (order == "online")
                    {
                        price3 = price3 - (price3 * 0.02);
                        Console.WriteLine("{0:f2}BGN", price3);
                    }
                    else if (order == "office")
                    {
                        Console.WriteLine("{0:f2}BGN", price3);
                    }
                    break;
                case "20X30":
                    if (picturesNumber >= 10 && picturesNumber <= 50)
                    {
                        price4 = price4 - (price4 * 0.07);
                    }
                    else if (picturesNumber > 50)
                    {
                        price4 = price4 - (price4 * 0.09);
                    }
                    if (order == "online")
                    {
                        price4 = price4 - (price4 * 0.02);
                        Console.WriteLine("{0:f2}BGN", price4);
                    }
                    else if (order == "office")
                    {
                        Console.WriteLine("{0:f2}BGN", price4);
                    }
                    break;
            }

        }
    }
}
