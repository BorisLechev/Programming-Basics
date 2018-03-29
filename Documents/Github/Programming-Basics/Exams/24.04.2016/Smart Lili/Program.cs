using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lili
{
    class Program
    {
        static void Main(string[] args) // !!!!!!!!!!
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toyCounter = 0;
            int count = 0;
            int evenBirthDays = 0;
            int money = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    toyCounter++;
                }
                else
                {
                    count++;
                    evenBirthDays += 10;
                    money += evenBirthDays;
                }
            }
            toyPrice *= toyCounter;
            double allMoney = toyPrice + money - count;
            double moneyDiff = allMoney - washingMachinePrice;
            if (moneyDiff >= 0)
            {
                Console.WriteLine("Yes! {0:f2}", moneyDiff);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", Math.Abs(moneyDiff));
            }
        }
    }
}
