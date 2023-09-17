using System;
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
            int levelChoice = 1;
            int difficulty = 1;
            while (menuIsOn)
            {
                int choice;
                Console.Clear();
                Console.WriteLine("┌───────────────────────────────┐");
                Console.WriteLine("│Welcome to the Snake Game menu!│");
                Console.WriteLine("├───────────────────────────────┤");
                Console.WriteLine($"│Level: {levelChoice} Difficulty: {difficulty}         │");
                Console.WriteLine("├───────────────────────────────┤");
                Console.WriteLine("│0. Quit                        │");
                Console.WriteLine("│1. Choose level                │");
                Console.WriteLine("│2. Choose difficulty           │");
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
                            Console.WriteLine("│Choose a difficulty:           │");
                            Console.WriteLine("├───────────────────────────────┤");
                            Console.WriteLine($"│Current difficulty: {difficulty}          │");
                            Console.WriteLine("├───────────────────────────────┤");
                            Console.WriteLine("│1. Easy                        │");
                            Console.WriteLine("│2. Medium                      │");
                            Console.WriteLine("│3. Hard                        │");
                            Console.WriteLine("│                               │");
                            Console.WriteLine("└───────────────────────────────┘");
                            var difficultyInput = Console.ReadKey(true);
                            bool checkDifficultyInput = int.TryParse(difficultyInput.KeyChar.ToString(), out difficulty);
                            if (difficulty > 3 || difficulty < 1)
                            {
                                difficulty = 1;
                            }
                            if (checkDifficultyInput == true)
                            {
                                if (difficulty == 1)
                                {
                                    Levels._difficulty = 800;
                                }
                                if (difficulty == 2)
                                {
                                    Levels._difficulty = 500;
                                }
                                if (difficulty == 3)
                                {
                                    Levels._difficulty = 200;
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
                                Console.WriteLine("Error 1. Could not start game.");
                                Console.WriteLine("Try choosing a different level.");
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
