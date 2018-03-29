using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinutes = int.Parse(Console.ReadLine());
            var arriveHour = int.Parse(Console.ReadLine());
            var arriveMinutes = int.Parse(Console.ReadLine());
            var timeExam = examHour * 60 + examMinutes;
            var timeArrival = arriveHour * 60 + arriveMinutes;
            var timeDiff = timeArrival - timeExam;
            if (timeDiff < -30) Console.WriteLine("Early");
            else if (timeDiff <= 0) Console.WriteLine("On time");
            else Console.WriteLine("Late");
            if (timeDiff != 0)
            {
                var hours = Math.Abs(timeDiff / 60);
                var minutes = Math.Abs(timeDiff % 60);

                if (hours > 0)
                {
                    if (minutes < 10) Console.WriteLine(hours + ":0" + minutes + "hours");
                    else Console.WriteLine(hours + ":" + minutes + "hours");
                }
                else Console.WriteLine(minutes + " " + "minutes");
                if (timeDiff < 0) Console.WriteLine("before the start");
                else Console.WriteLine("after start");
            }
                
        }
    }
}
