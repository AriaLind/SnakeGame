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
            int levelChoice = 0;
            while (menuIsOn)
            {
                int choice;
                Console.Clear();
                Console.WriteLine("┌───────────────────────────────┐");
                Console.WriteLine("│Welcome to the Snake Game menu!│▒");
                Console.WriteLine("├───────────────────────────────┤▒");
                Console.WriteLine($"│Chosen level: {levelChoice}                │▒");
                Console.WriteLine("├───────────────────────────────┤▒");
                Console.WriteLine("│0. Quit                        │▒");
                Console.WriteLine("│1. Choose level                │▒");
                Console.WriteLine("│2. Start                       │▒");
                Console.WriteLine("└───────────────────────────────┘▒");
                Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                bool inputIsCorrect = int.TryParse(Console.ReadLine(), out choice);
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
                            Console.WriteLine("Choose a level!");
                            Console.WriteLine("1. First level");
                            bool correctInput = int.TryParse(Console.ReadLine(), out levelChoice);
                            break;
                        case 2:
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
