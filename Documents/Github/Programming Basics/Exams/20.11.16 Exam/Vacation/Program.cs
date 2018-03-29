using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var adultsNumber = int.Parse(Console.ReadLine());
            var studentsNumber = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();
            var adults = 0.0;
            var students = 0.0;
            var price = 0.0;
            var people = adultsNumber + studentsNumber;
            var hotel = nights * 82.99;
            switch (transport)
            {
                case "train":
                    adults = 24.99;
                    students = 14.99;
                    price = (adults * adultsNumber + students * studentsNumber) * 2;
                    if (people > 50)
                        price = (price - price * 0.5) * 2;
                    break;
                case "bus":
                    adults = 32.5;
                    students = 28.5;
                    price = (adults * adultsNumber + students * studentsNumber) * 2;
                    break;
                case "boat":
                    adults = 42.99;
                    students = 39.99;
                    price = (adults * adultsNumber + students * studentsNumber) * 2;
                    break;
                case "airplane":
                    adults = 70;
                    students = 50;
                    price = (adults * adultsNumber + students * studentsNumber) * 2;
                    break;

            }
            var comission = (price + hotel) * 0.1;
            var sum = price + hotel + comission;
            Console.WriteLine("{0:f2}", sum);

        }
    }
}
