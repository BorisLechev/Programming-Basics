using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Name
{
    class Program
    {
        static void Main(string[] args) // !!!!!!!!!
        {
            char bigLetter = char.Parse(Console.ReadLine());
            char firstSmallLetter = char.Parse(Console.ReadLine());
            char secondSmallLetter = char.Parse(Console.ReadLine());
            char thirthSmallLetter = char.Parse(Console.ReadLine());
            int figure = int.Parse(Console.ReadLine());
            int counter = 0;
            for (char big = 'A'; big <= bigLetter; big++)
            {
                for (char first = 'a'; first <= firstSmallLetter; first++)
                {
                    for (char second = 'a'; second <= secondSmallLetter; second++)
                    {
                        for (char third = 'a'; third <= thirthSmallLetter; third++)
                        {
                            for (int number = 0; number <= figure; number++)
                            {
                                if (big == bigLetter && first == firstSmallLetter && second == secondSmallLetter && third == thirthSmallLetter && number == figure)
                                {
                                    break;
                                }
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
