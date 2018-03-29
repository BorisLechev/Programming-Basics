using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Cocktails
{
    class Program
    {
        static void Main(string[] args) 
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int order = int.Parse(Console.ReadLine());
            double smallWatermelon = 56 * 2 * order;
            double bigWatermelon = 28.7 * 5 * order;
            double smallMango = 36.66 * 2 * order;
            double bigMango = 19.6 * 5 * order;
            double smallPineApple = 42.1 * 2 * order;
            double bigPineApple = 24.8 * 5 * order;
            double smallRaspberry = 20 * 2 * order;
            double bigRaspberry = 15.2 * 5 * order;
            double price = 0.0;
            switch (fruit)
            {
                case "Watermelon":
                    if (size == "big")
                    {
                        price = bigWatermelon;
                        if (price > 400 && price < 1000)
                        {
                            price -= price * 0.15;
                        }
                        else if (price > 1000)
                        {
                            price -= price * 0.5;
                        }
                    }
                    else if (size == "small")
                    {
                        price = smallWatermelon;
                        if (price > 400 && price < 1000)
                        {
                            price -= price * 0.15;
                        }
                        else if (price > 1000)
                        {
                            price -= price * 0.5;
                        }
                    }
                    Console.WriteLine("{0:f2} lv.", price);
                    break;

                case "Mango":
                    if (size == "big")
                    {
                        price = bigMango;
                        if (price > 400 && price < 1000)
                        {
                            price -= price * 0.15;
                        }
                        else if (price > 1000)
                        {
                            price -= price * 0.5;
                        }
                    }
                    else if (size == "small")
                    {
                        price = smallMango;
                        if (price > 400 && price < 1000)
                        {
                            price -= price * 0.15;
                        }
                        else if (price > 1000)
                        {
                            price -= price * 0.5;
                        }
                    }
                    Console.WriteLine("{0:f2} lv.", price);
                    break;

                case "Pineapple":
                    if (size == "big")
                    {
                        price = bigPineApple;
                        if (price > 400 && price < 1000)
                        {
                            price -= price * 0.15;
                        }
                        else if (price > 1000)
                        {
                            price -= price * 0.5;
                        }
                    }
                    else if (size == "small")
                    {
                        price = smallPineApple;
                        if (price > 400 && price < 1000)
                        {
                            price -= price * 0.15;
                        }
                        else if (price > 1000)
                        {
                            price -= price * 0.5;
                        }
                    }
                    Console.WriteLine("{0:f2} lv.", price);
                    break;

                case "Raspberry":
                    if (size == "big")
                    {
                        price = bigRaspberry;
                        if (price > 400 && price < 1000)
                        {
                            price -= price * 0.15;
                        }
                        else if (price > 1000)
                        {
                            price -= price * 0.5;
                        }
                    }
                    else if (size == "small")
                    {
                        price = smallRaspberry;
                        if (price > 400 && price < 1000)
                        {
                            price -= price * 0.15;
                        }
                        else if (price > 1000)
                        {
                            price -= price * 0.5;
                        }
                    }
                    Console.WriteLine("{0:f2} lv.", price);
                    break;
            }
        }
    }
}