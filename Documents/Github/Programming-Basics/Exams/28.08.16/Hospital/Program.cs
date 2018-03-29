using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital //!!!!!!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            var treatedPatients = 0;
            var untreatedPatients = 0;
            var countofDoctors = 7;
            for (var days = 1; days <= period; days++)
            {
                var currentPatients = int.Parse(Console.ReadLine());
                if ((days % 3 == 0) && (untreatedPatients > treatedPatients))
                {
                    countofDoctors++;
                }
                if (currentPatients > countofDoctors)
                {
                    treatedPatients += countofDoctors;
                    untreatedPatients += currentPatients - countofDoctors;
                }
                else
                {
                    treatedPatients += currentPatients;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}
