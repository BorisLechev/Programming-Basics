using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double expensesSummerBul = 0.05;
            double expensesWinterBul = 0.08;
            double expensesSummerAbroad = 0.1;
            double expensesWinterAbroad = 0.15;
            double money = 0.0;
            double moneyAfterExpenses = 0.0;
            double moneyForCharity = 0.0;
            double leftMoney = 0.0;
            double moneyPerDancer = 0.0;
            if (place == "Bulgaria")
            {
                if (season == "summer")
                {
                    money = dancers * points;
                    moneyAfterExpenses = money - money * expensesSummerBul;
                    moneyForCharity = moneyAfterExpenses * 0.75;
                    leftMoney = moneyAfterExpenses - moneyForCharity;
                    moneyPerDancer = leftMoney / dancers;
                }
                else if (season == "winter")
                {
                    money = dancers * points;
                    moneyAfterExpenses = money - money * expensesWinterBul;
                    moneyForCharity = moneyAfterExpenses * 0.75;
                    leftMoney = moneyAfterExpenses - moneyForCharity;
                    moneyPerDancer = leftMoney / dancers;
                }
            }
            else if (place == "Abroad")
            {
                if (season == "summer")
                {
                    money = (dancers * points) + (dancers * points) * 0.5;
                    moneyAfterExpenses = money - money * expensesSummerAbroad;
                    moneyForCharity = moneyAfterExpenses * 0.75;
                    leftMoney = moneyAfterExpenses - moneyForCharity;
                    moneyPerDancer = leftMoney / dancers;
                }
                else if (season == "winter")
                {
                    money = (dancers * points) + (dancers * points) * 0.5;
                    moneyAfterExpenses = money - money * expensesWinterAbroad;
                    moneyForCharity = moneyAfterExpenses * 0.75;
                    leftMoney = moneyAfterExpenses - moneyForCharity;
                    moneyPerDancer = leftMoney / dancers;
                }
            }
            Console.WriteLine($"Charity - {moneyForCharity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");
        }
    }
}
