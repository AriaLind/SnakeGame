﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Menu
    {
        public void StartMenu()
        {
            bool menuIsOn = true;
            int levelChoice = 0;
            int speed = 0;
            while (menuIsOn)
            {
                int choice;
                Console.Clear();
                Console.WriteLine("┌───────────────────────────────┐");
                Console.WriteLine("│Welcome to the Snake Game menu!│");
                Console.WriteLine("├───────────────────────────────┤");
                Console.WriteLine($"│Level: {levelChoice} Difficulty: {speed}         │");
                Console.WriteLine("├───────────────────────────────┤");
                Console.WriteLine("│0. Quit                        │");
                Console.WriteLine("│1. Choose level                │");
                Console.WriteLine("│2. Choose speed                │");
                Console.WriteLine("│3. Start                       │");
                Console.WriteLine("└───────────────────────────────┘");
                bool inputIsCorrect = int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out choice);
                if (inputIsCorrect)
                {
                    switch(choice)
                    {
                        case 0:
                            menuIsOn = false;
                            Console.WriteLine("Press any key to quit.");
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("┌───────────────────────────────┐");
                            Console.WriteLine("│Choose a level:                │");
                            Console.WriteLine("├───────────────────────────────┤");
                            Console.WriteLine($"│Current level: {levelChoice}               │");
                            Console.WriteLine("├───────────────────────────────┤");
                            Console.WriteLine("│1. Level one                   │");
                            Console.WriteLine("│2. Level two                   │");
                            Console.WriteLine("│                               │");
                            Console.WriteLine("│                               │");
                            Console.WriteLine("└───────────────────────────────┘");
                            bool checkLevelInput = int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out levelChoice);
                            if (levelChoice > 2 || levelChoice < 1)
                            {
                                levelChoice = 1;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("┌───────────────────────────────┐");
                            Console.WriteLine("│Choose speed:                  │");
                            Console.WriteLine("├───────────────────────────────┤");
                            Console.WriteLine($"│Current speed:      {speed}          │");
                            Console.WriteLine("├───────────────────────────────┤");
                            Console.WriteLine("│1. Slow                        │");
                            Console.WriteLine("│2. Medium                      │");
                            Console.WriteLine("│3. Fast                        │");
                            Console.WriteLine("│4. Custom                      │");
                            Console.WriteLine("└───────────────────────────────┘");
                            var speedInput = Console.ReadKey(true);
                            bool checkSpeedInput = int.TryParse(speedInput.KeyChar.ToString(), out speed);
                            if (speed > 3 || speed < 1)
                            {
                                speed = 1;
                            }
                            if (checkSpeedInput == true)
                            {
                                if (speed == 1)
                                {
                                    Levels._difficulty = 400;
                                }
                                if (speed == 2)
                                {
                                    Levels._difficulty = 200;
                                }
                                if (speed == 3)
                                {
                                    Levels._difficulty = 100;
                                }
                            }
                            break;
                        case 3:
                            try
                            {
                                Game startGame = new Game(levelChoice - 1);
                                Console.ReadKey(true);
                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Error 1. Could not start game.");
                                Console.WriteLine("Try choosing a different level.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadKey(true);
                                Console.Clear();
                            }
                            break;
                    }
                }
            }
        }
    }
}
