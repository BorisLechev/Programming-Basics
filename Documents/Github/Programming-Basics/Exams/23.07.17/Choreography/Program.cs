using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double daysForLearning = double.Parse(Console.ReadLine());
            double stepsPerDay = Math.Ceiling((steps / daysForLearning) / steps * 100);
            double stepsForEveryDancer = stepsPerDay / dancers;
            if (13 >= stepsPerDay)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsForEveryDancer:f2}%.");
            }
            else if (stepsPerDay > 13)
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepsForEveryDancer:f2}% steps to be learned per day.");
            }
        }
    }
}
