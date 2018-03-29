using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Intervals
{
    class Program
    {
        static void Main(string[] args) 
        {
            var numberOfRounds = int.Parse(Console.ReadLine());
            var result = 0.0;
            var count = 0.0;
            var count1 = 0.0;
            var count2 = 0.0;
            var count3 = 0.0;
            var count4 = 0.0;
            var count5 = 0.0;
            for (var i = 0; i < numberOfRounds; i++)
            {
                var points = int.Parse(Console.ReadLine());
                if (points < 0 || points > 50)
                {
                    result = result / 2;
                    count++;
                }
                else if (points >= 0 && points <= 9)
                {
                    result += points * 0.2;
                    count1++;
                }
                else if (points >= 10 && points <= 19)
                {
                    result += points * 0.3;
                    count2++;
                }
                else if (points >= 20 && points <= 29)
                {
                    result += points * 0.4;
                    count3++;
                }
                else if (points >= 30 && points <= 39)
                {
                    result += 50.0;
                    count4++;
                }
                else if (points >= 40 && points <= 50)
                {
                    result += 100.0;
                    count5++;
                }
            }
            Console.WriteLine("{0:f2}", result);
            Console.WriteLine("From 0 to 9: {0:f2}%", count1 / numberOfRounds * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", count2 / numberOfRounds * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", count3 / numberOfRounds * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", count4 / numberOfRounds * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", count5 / numberOfRounds * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%", count / numberOfRounds * 100);
        }
    }
}
