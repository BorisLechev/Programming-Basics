using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeLeva = double.Parse(Console.ReadLine());
            double average = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScholarship = 0.0;
            double scholarship2 = 0.0;

            if (average < 5.5 && incomeLeva > minSalary)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (average < 4.5 && incomeLeva > minSalary)
            {
                Console.WriteLine("You cannot get a scholarship!");

            }
            else if (average < 4.5 && incomeLeva == minSalary)
            {
                Console.WriteLine("You cannot get a scholarship!");

            }
            else if (average < 4.5 && incomeLeva < minSalary)
            {
                Console.WriteLine("You cannot get a scholarship!");

            }
            else if (average >= 5.5 && incomeLeva > minSalary)
            {
                scholarship2 = average * 25;
                Console.WriteLine($"You get a scholarship for excellent results {scholarship2} BGN");
            }
            else if (average >= 5.5 && incomeLeva < minSalary)
            {
                scholarship2 = average * 25;
                Console.WriteLine($"You get a scholarship for excellent results {scholarship2} BGN");
            }
            else if (average >= 5.5 && incomeLeva == minSalary)
            {
                scholarship2 = average * 25;
                socialScholarship = minSalary * 0.35;
                if (socialScholarship > scholarship2)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarship2} BGN");
                }
            }
            else if (incomeLeva < minSalary && average >= 4.5)
            {
                socialScholarship = minSalary * 0.35;
                if (average >= 5.5)
                {
                    scholarship2 = average * 25;
                }
                if (socialScholarship > scholarship2)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarship2} BGN");
                }
            }
        }
    }
}
