using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());

            int doctorsCount = 7;

            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int currentDay = 1; currentDay <= daysCount; currentDay++)
            {
                int patientsToTreat = int.Parse(Console.ReadLine());

                if (currentDay % 3 == 0 && treatedPatients > untreatedPatients)
                {
                    doctorsCount++;
                }
                if (patientsToTreat > doctorsCount)
                {
                    // calculate the untreated
                    treatedPatients += doctorsCount;
                    untreatedPatients += patientsToTreat - doctorsCount;
                }
                else
                {
                    treatedPatients += patientsToTreat;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}

