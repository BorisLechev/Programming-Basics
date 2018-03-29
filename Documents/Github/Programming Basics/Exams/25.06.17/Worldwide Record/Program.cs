using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worldwide_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            var record = double.Parse(Console.ReadLine());
            var distance = double.Parse(Console.ReadLine());
            var timeforaSecond = double.Parse(Console.ReadLine());
            var swimming = distance * timeforaSecond;
            var delay = Math.Floor(distance / 15);
            var continueDalay = (delay * 12.5);
            var sumTime = swimming + continueDalay;
            var extract = sumTime - record;
            if (record < sumTime)
            {
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", extract);
            }
            else if (sumTime < record)
            {
                Console.WriteLine("Yes, he succeeded!The new world record is {0:f2} seconds.", sumTime);
            }
        }
    }
}
var fruit = Console.ReadLine();
var size = Console.ReadLine();
var order = int.Parse(Console.ReadLine());
var price1 = 5 * 28.7 * order;
var price2 = 2 * 56 * order;
var price3 = 5 * 19.6 * order;
var price4 = 2 * 36.66 * order;
var price5 = 5 * 24.8 * order;
var price6 = 2 * 42.1 * order;
var price7 = 5 * 15.2 * order;
var price8 = 2 * 20.0 * order;

            if (price1 >= 400 || price2 >= 400 || price3 >= 400 || price4 >= 400 || price5 >= 400 || price6 >= 400 || price7 >= 400 || price8 >= 400 &&
                price1< 1000 || price2< 1000 || price3< 1000 || price4< 1000 || price5< 1000 || price6< 1000 || price7< 1000 || price8< 1000)
            {
                 if (fruit == "watermelon")
                 {
                    if (size == "big")
                    {
                        Console.WriteLine("{0:f2}", price1 - price1* 0.15);
                    }
                    else if (size == "small")
                    {
                        Console.WriteLine("{0:f2}", price2 - price2* 0.15);
                    }
                 }
                 else if (fruit == "mango")
                 {
                    if (size == "big")
                    {
                        Console.WriteLine("{0:f2}", price3 - price3* 0.15);
                    }
                    else if (size == "small")
                    {
                        Console.WriteLine("{0:f2}", price4 - price4* 0.15);
                    }
                 }
                else if (fruit == "pineapple")
                {
                    if (size == "big")
                    {
                        Console.WriteLine("{0:f2}", price5 - price5* 0.15);
                    }
                    else if (size == "small")
                    {
                        Console.WriteLine("{0:f2}", price6 - price6* 0.15);
                    }
                }
                else if (fruit == "raspberry")
                {
                    if (size == "big")
                    {
                        Console.WriteLine("{0:f2}", price7 - price7* 0.15);
                    }
                    else if (size == "small")
                    {
                        Console.WriteLine("{0:f2}", price8 - price8* 0.15);
                    }
                }
            }
                else if (price1 > 1000 || price2 > 1000 || price3 > 1000 || price4 > 1000 || price5 > 1000 || price6 > 1000 || price7 > 1000 || price8 > 1000)
                {
                if (fruit == "watermelon")
                {
                    if (size == "big")
                    {
                        Console.WriteLine("{0:f2}", price1 - price1* 0.5);
                    }
                    else if (size == "small")
                    {
                        Console.WriteLine("{0:f2}", price2 - price2* 0.5);
                    }
                }
                else if (fruit == "mango")
                {
                    if (size == "big")
                    {
                        Console.WriteLine("{0:f2}", price3 - price3* 0.5);
                    }
                    else if (size == "small")
                    {
                        Console.WriteLine("{0:f2}", price4 - price4* 0.5);
                    }
                }
                else if (fruit == "pineapple")
                {
                    if (size == "big")
                    {
                        Console.WriteLine("{0:f2}", price5 - price5* 0.5);
                    }
                    else if (size == "small")
                    {
                        Console.WriteLine("{0:f2}", price6 - price6* 0.5);
                    }
                }
                else if (fruit == "raspberry")
                {
                    if (size == "big")
                    {
                        Console.WriteLine("{0:f2}", price7 - price7* 0.5);
                    }
                    else if (size == "small")
                    {
                        Console.WriteLine("{0:f2}", price8 - price8* 0.5);
                    }
                }
            }
            else if (price1< 100 || price2< 100 || price3< 100 || price4< 100 || price5< 100 || price6< 100 || price7< 100 || price8< 100)
            {
                if (fruit == "watermelon")
                {
                    if (size == "big")
                    {
                        Console.WriteLine("{0:f2}", price1);
                    }
                    else if (size == "small")
                    {
                        Console.WriteLine("{0:f2}", price2);
                    }
                }
                else if (fruit == "mango")
                {
                    if (size == "big")
                    {
                        Console.WriteLine("{0:f2}", price3);
                    }
                    else if (size == "small")
                    {
                        Console.WriteLine("{0:f2}", price4);
                    }
                }
                else if (fruit == "pineapple")
                {
                    if (size == "big")
                    {
                        Console.WriteLine("{0:f2}", price5);
                    }
                    else if (size == "small")
                    {
                        Console.WriteLine("{0:f2}", price6);
                    }
                }
                else if (fruit == "raspberry")
                {
                    if (size == "big")
                    {
                        Console.WriteLine("{0:f2}", price7);
                    }
                    else if (size == "small")
                    {
                        Console.WriteLine("{0:f2}", price8);
                    }
                }
            }

        }
    }
}

