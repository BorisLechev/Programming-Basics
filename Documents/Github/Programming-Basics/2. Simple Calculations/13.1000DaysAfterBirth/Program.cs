using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthDay = Console.ReadLine();
            var birthDayDateTime =
            DateTime.ParseExact(birthDay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            for (int i = 0; i < 999; i++)
            {
                birthDayDateTime = birthDayDateTime.AddDays(1);
            }
            Console.WriteLine(birthDayDateTime.ToString("dd-MM-yyyy"));
        }
    }
}
