using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrase = Console.ReadLine();
            if (phrase == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
