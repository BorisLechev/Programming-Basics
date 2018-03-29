using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args) 
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var c = 97;
            var d = 97;
            var bigger = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 0; k < l; k++)
                    {
                        for (int m = 0; m < l; m++)
                        {
                            if (i > j)
                            {
                                bigger = i + 1;
                            }
                            else
                            {
                                bigger = j + 1;
                            }
                            for (int o = bigger; o <= n; o++)
                            {
                                Console.Write("{0}{1}", i, j);
                                var symbol3 = Char.ConvertFromUtf32(c + k);
                                var symbol4 = Char.ConvertFromUtf32(d + m);
                                Console.Write("{0}{1}", symbol3, symbol4);
                                Console.Write("{0} ", o);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

