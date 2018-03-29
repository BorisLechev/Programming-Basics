using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniSpaceInvader
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Setting Console width and height
            int width = 30;
            int height = 35;
            Console.SetWindowSize(width, height);
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            // Setting cursor visability
            Console.CursorVisible = false;
            // Setting the initial values of the Spaceship

            char spaceShip = '^';
            int rowOfSpaceShip = Console.WindowHeight - 1;
            int colOfSpaceShip = 0;

            char spaceShipProjectile = '|';

            // Setting up the enemy generator
            Random enemyGenerator = new Random();
            int minGeneratedRow = 0;
            int maxGeneratedRow = Console.WindowHeight / 2;
            int minGeneratedCol = 0;
            int maxGeneratedCol = Console.WindowWidth;

            // Setting up the enemies

            char enemy = '*';
            int rowOfEnemy = enemyGenerator.Next(minGeneratedRow, maxGeneratedCol);
            int colOfEnemy = enemyGenerator.Next(minGeneratedCol, maxGeneratedCol);
            // Start game

            Console.SetCursorPosition(colOfSpaceShip, rowOfSpaceShip);
            Console.Write(spaceShip);

            Console.SetCursorPosition(colOfEnemy, rowOfEnemy);
            Console.Write(enemy);
            while (true)
            {
                ConsoleKeyInfo currentPressedKey = Console.ReadKey();
                if (currentPressedKey.Key == ConsoleKey.LeftArrow &&
                    colOfSpaceShip >= 1)
                {
                    // diga <-
                    colOfSpaceShip--;

                }
                else if (currentPressedKey.Key == ConsoleKey.RightArrow &&
                    colOfSpaceShip <= Console.WindowWidth - 2)
                {
                    // dviga ->
                    colOfSpaceShip++;
                }
                else if (currentPressedKey.Key == ConsoleKey.Spacebar)
                {
                    // shoot the enemy
                    int rowOfProjectile = rowOfSpaceShip - 1;
                    int colOfProjectile = colOfSpaceShip;
                    while (rowOfProjectile > 0) 
                    {
                        Console.Clear();

                        Console.SetCursorPosition(colOfProjectile, rowOfProjectile);
                        Console.Write(spaceShipProjectile);

                        Console.SetCursorPosition(colOfEnemy, rowOfEnemy);
                        Console.Write(enemy);

                        Console.SetCursorPosition(colOfSpaceShip, rowOfSpaceShip);
                        Console.Write(spaceShip);

                        

                        Thread.Sleep(70);


                        rowOfProjectile--;
                    }
                }
                Console.Clear();


                Console.SetCursorPosition(colOfSpaceShip, rowOfSpaceShip);
                Console.Write(spaceShip);

                Console.SetCursorPosition(colOfEnemy, rowOfEnemy);
                Console.Write(enemy);
            }
            
        }
    }
}
