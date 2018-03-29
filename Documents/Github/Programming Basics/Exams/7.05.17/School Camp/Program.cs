using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var typeGroup = Console.ReadLine();
            var studentsNumber = int.Parse(Console.ReadLine());
            var nightsNumber = int.Parse(Console.ReadLine());
            var priceforGirls = 0.0;
            var priceforBoys = 0.0;
            var priceforMix = 0.0;
            switch (season)
            {
                case "Winter":
                    priceforGirls = 9.6;
                    priceforBoys = 9.6;
                    priceforMix = 10;
                    if (typeGroup == "girls")
                    {
                        Console.Write("Gymnastics");
                    }
                    else if (typeGroup == "boys")
                    {
                        Console.Write("Judo");
                    }
                    else if (typeGroup == "mixed")
                    {
                        Console.Write("Ski");
                    }
                    if (studentsNumber > 50)
                    {
                        priceforGirls -= 9.6 * 0.5;
                        priceforBoys -= 9.6 * 0.5;
                        priceforMix -= 10 * 0.5;
                    }
                    else if (studentsNumber > 20 && studentsNumber <= 50)
                    {
                        priceforGirls -= 9.6 * 0.15;
                        priceforBoys -= 9.6 * 0.15;
                        priceforMix -= 10 * 0.15;
                    }
                    else if (studentsNumber > 10 && studentsNumber <= 20)
                    {
                        priceforGirls -= 9.6 * 0.05;
                        priceforBoys -= 9.6 * 0.05;
                        priceforMix -= 10 * 0.05;
                    }
                    break;
                case "Spring":
                    priceforGirls = 7.2;
                    priceforBoys = 7.2;
                    priceforMix = 9.5;
                    if (typeGroup == "girls")
                    {
                        Console.Write("Athletics");
                    }
                    else if (typeGroup == "boys")
                    {
                        Console.Write("Tennis");
                    }
                    else if (typeGroup == "mixed")
                    {
                        Console.Write("Cycling");
                    }
                    if (studentsNumber > 50)
                    {
                        priceforGirls -= 7.2 * 0.5;
                        priceforBoys -= 7.2 * 0.5;
                        priceforMix -= 9.5 * 0.5;
                    }
                    else if (studentsNumber >= 20 && studentsNumber <= 50)
                    {
                        priceforGirls -= 7.2 * 0.15;
                        priceforBoys -= 7.2 * 0.15;
                        priceforMix -= 9.5 * 0.15;
                    }
                    else if (studentsNumber > 10 && studentsNumber < 20)
                    {
                        priceforGirls -= 7.2 * 0.05;
                        priceforBoys -= 7.2 * 0.05;
                        priceforMix -= 9.5 * 0.05;
                    }
                    break;
                case "Summer":
                    priceforGirls = 15;
                    priceforBoys = 15;
                    priceforMix = 20;
                    if (typeGroup == "girls")
                    {
                        Console.Write("Volleyball");
                    }
                    else if (typeGroup == "boys")
                    {
                        Console.Write("Football");
                    }
                    else if (typeGroup == "mixed")
                    {
                        Console.Write("Swimming");
                    }
                    if (studentsNumber > 50)
                    {
                        priceforGirls -= 15 * 0.5;
                        priceforBoys -= 15 * 0.5;
                        priceforMix -= 20 * 0.5;
                    }
                    else if (studentsNumber > 20 && studentsNumber <= 50)
                    {
                        priceforGirls -= 15 * 0.15;
                        priceforBoys -= 15 * 0.15;
                        priceforMix -= 20 * 0.15;
                    }
                    else if (studentsNumber > 10 && studentsNumber <= 20)
                    {
                        priceforGirls -= 15 * 0.05;
                        priceforBoys -= 15 * 0.05;
                        priceforMix -= 20 * 0.05;
                    }
                    break;
            }
            var priceNights1 = studentsNumber * priceforGirls * nightsNumber;
            var priceNights2 = studentsNumber * priceforBoys * nightsNumber;
            var priceNights3 = studentsNumber * priceforMix * nightsNumber;
            if (typeGroup == "girls")
            {
                Console.Write(" {0:f2} lv.", priceNights1);
            }
            else if (typeGroup == "boys")
            {
                Console.Write(" {0:f2} lv.", priceNights2);
            }
            else if (typeGroup == "mixed")
            {
                Console.Write(" {0:f2} lv.", priceNights3);
            }
            Console.WriteLine();
        }
    }
}
