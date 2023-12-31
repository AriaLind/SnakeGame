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
                Console.WriteLine("┌────────────────────────────────┐");
                Console.WriteLine("│           SNAKE MENU           │");
                Console.WriteLine("├────────────────────────────────┤");
                Console.WriteLine($"│Level: {levelChoice} Difficulty: {speed}          │");
                Console.WriteLine("├────────────────────────────────┤");
                Console.WriteLine("│0. Quit                         │");
                Console.WriteLine("│1. Choose level                 │");
                Console.WriteLine("│2. Choose speed                 │");
                Console.WriteLine("│3. Start                        │");
                Console.WriteLine("│4. Leaderboards                 │");
                Console.WriteLine("└────────────────────────────────┘");
                bool inputIsCorrect = int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out choice);
                if (inputIsCorrect)
                {
                    switch (choice)
                    {
                        case 0:
                            menuIsOn = false;
                            Console.WriteLine("Press any key to quit.");
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("┌────────────────────────────────┐");
                            Console.WriteLine("│          CHOOSE LEVEL          │");
                            Console.WriteLine("├────────────────────────────────┤");
                            Console.WriteLine($"│Current level: {levelChoice}                │");
                            Console.WriteLine("├────────────────────────────────┤");
                            Console.WriteLine("│1. Small level                  │");
                            Console.WriteLine("│2. Large level                  │");
                            Console.WriteLine("│                                │");
                            Console.WriteLine("│                                │");
                            Console.WriteLine("│                                │");
                            Console.WriteLine("└────────────────────────────────┘");
                            bool checkLevelInput = int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out levelChoice);
                            if (levelChoice > 2 || levelChoice < 1)
                            {
                                levelChoice = 1;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("┌────────────────────────────────┐");
                            Console.WriteLine("│           GAME SPEED           │");
                            Console.WriteLine("├────────────────────────────────┤");
                            Console.WriteLine($"│Current speed:      {speed}           │");
                            Console.WriteLine("├────────────────────────────────┤");
                            Console.WriteLine("│1. Slow                         │");
                            Console.WriteLine("│2. Medium                       │");
                            Console.WriteLine("│3. Fast                         │");
                            Console.WriteLine("│4. Even faster                  │");
                            Console.WriteLine("│5. Way too fast                 │");
                            Console.WriteLine("└────────────────────────────────┘");
                            var speedInput = Console.ReadKey(true);
                            bool checkSpeedInput = int.TryParse(speedInput.KeyChar.ToString(), out speed);
                            if (speed > 5 || speed < 1)
                            {
                                speed = 1;
                            }
                            if (checkSpeedInput)
                            {
                                switch (speed)
                                {
                                    case 1:
                                        Levels._speed = 400;
                                        break;
                                    case 2:
                                        Levels._speed = 200;
                                        break;
                                    case 3:
                                        Levels._speed = 100;
                                        break;
                                    case 4:
                                        Levels._speed = 50;
                                        break;
                                    case 5:
                                        Levels._speed = 25;
                                        break;
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
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Under construction.");
                            Console.ReadKey(true);
                            break;
                    }
                }
            }
        }
    }
}
