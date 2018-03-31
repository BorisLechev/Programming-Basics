using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam // ????????
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourExam = int.Parse(Console.ReadLine());
            var minuteExam = int.Parse(Console.ReadLine());
            var hourArrive = int.Parse(Console.ReadLine());
            var minuteArrive = int.Parse(Console.ReadLine());
            var timeExam = hourExam * 60 + minuteExam;
            var timeArrive = hourArrive * 60 + minuteArrive;
            var timeDiff = timeArrive - timeExam;
            if (timeDiff < -30) Console.WriteLine("Early");
            else if (timeDiff <= 0) Console.WriteLine("On time");
            else Console.WriteLine("Late");
            if (timeDiff != 0)
            {
                var hours = Math.Abs(timeDiff / 60);
                var minutes = Math.Abs(timeDiff % 60);
                if (hours > 0)
                {
                    if (minutes < 10) Console.Write(hours + ":0" + minutes + " hours");
                    else Console.Write(hours + ":" + minutes + "hours");
                }
                else Console.Write(minutes + " " + "minutes");
                if (timeDiff > 0) Console.Write(" after the start");
                else Console.Write(" before the start");
            }
            Console.WriteLine();
        }
    }
}
