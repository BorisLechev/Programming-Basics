using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lection = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            var sumOneLection = budget / lection;
            var Jelev = 0;
            var RoYal = 0;
            var Roli = 0;
            var Trofon = 0;
            var Sino = 0;
            var Others = 0;
            for (int i = 0; i < lection; i++)
            {
                var lector = Console.ReadLine();
                if (lector == "Jelev")
                    Jelev++;
                else if (lector == "RoYaL")
                    RoYal++;
                else if (lector == "Roli")
                    Roli++;
                else if (lector == "Trofon")
                    Trofon++;
                else if (lector == "Sino")
                    Sino++;
                else if (lector != "Jelev" && lector != "RoYal" && lector != "Roli" && lector != "Trofon" && lector != "Sino")
                    Others++;
            }
            Console.WriteLine("Jelev salary: {0:f2} lv", Jelev * sumOneLection);
            Console.WriteLine("RoYaL salary: {0:f2} lv", RoYal * sumOneLection);
            Console.WriteLine("Roli salary: {0:f2} lv", Roli * sumOneLection);
            Console.WriteLine("Trofon salary: {0:f2} lv", Trofon * sumOneLection);
            Console.WriteLine("Sino salary: {0:f2} lv", Sino * sumOneLection);
            Console.WriteLine("Others salary: {0:f2} lv", Others * sumOneLection);
        }
    }
}
