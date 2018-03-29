using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = char.Parse(Console.ReadLine());
            var last = char.Parse(Console.ReadLine());
            var toSkip = char.Parse(Console.ReadLine());
            var combinations = 0;
            for (char firstLetter = start; firstLetter <= last; firstLetter++)
            {
                for (char secondLetter = start; secondLetter <= last; secondLetter++)
                {
                    for (char thirdLetter = start; thirdLetter <= last; thirdLetter++)
                    {
                        if (firstLetter != toSkip && secondLetter != toSkip && thirdLetter != toSkip)
                        {
                            Console.Write("{0}{1}{2} ", firstLetter, secondLetter, thirdLetter);
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine(" {0}", combinations);
        }
    }
}
