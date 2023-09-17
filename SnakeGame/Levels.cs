using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    static public class Levels
    {
        
        static public int _score = 0;
        static List<string[,]> _allLevels = new List<string[,]>();
        static string[] _colliders = { "╔", "╗", "╚", "╝", "═" };
        static public bool _food = false;
        static public int[] _foodPosition = new int[2];
        static public int _levelChoice;
        static public int _difficulty;
        static Levels()
        {
            _allLevels.Add(_levelOne);
            _allLevels.Add(_levelTwo);
        }
        public static void ChooseLevel(int levelChoice)
        {
            _levelChoice = levelChoice;
        }
        public static void RenderLevel()
        {
            _score = 0;
            string[,] chosenLevel = _allLevels[_levelChoice];
            for (int i = 0; i < _allLevels[_levelChoice].GetLength(0); i++)
            {
                for (int j = 0; j < _allLevels[_levelChoice].GetLength(1); j++)
                {
                    Console.Write(chosenLevel[i, j]);
                }
                Console.WriteLine();
            }
            int writeAtEdge = _allLevels[_levelChoice].GetLength(1);
            Console.SetCursorPosition(writeAtEdge, 0);
            Console.Write("┌──────────────┐");
            Console.SetCursorPosition(writeAtEdge, 1);
            Console.Write("│              │");
            Console.SetCursorPosition(writeAtEdge, 2);
            Console.Write("│              │");
            Console.SetCursorPosition(writeAtEdge, 3);
            Console.Write($"└──────────────┘");
            Console.SetCursorPosition(writeAtEdge + 1, 1);
            Console.Write($"Level: {_levelChoice + 1}");

        }
        public static void RenderScore()
        {
            int writeAtEdge = _allLevels[_levelChoice].GetLength(1);
            Console.SetCursorPosition(writeAtEdge + 1, 2);
            Console.Write($"Score: {_score}");

        }
        public static void SnakeFood()
        {
            Random _rnd = new Random();
            _foodPosition[0] = _rnd.Next(1, _allLevels[_levelChoice].GetLength(1) - 2);
            _foodPosition[1] = _rnd.Next(1, _allLevels[_levelChoice].GetLength(0) - 2);
        }
        public static void CheckWalls(int positionX, int positionY)
        {
        }
        static string[,] _levelOne = new string[,]
        {
            {"╔", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═","═", "═", "═", "═", "═", "╗",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"╚", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═","═", "═", "═", "═", "═", "╝",},
        };
        static string[,] _levelTwo = new string[,]
        {
            {"╔", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═","═", "═", "═", "═", "═", "╗",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", "╔", "═", "╗", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", "║", " ", "║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", "╚", "═", "╝", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"║", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ","║",},
            {"╚", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═", "═","═", "═", "═", "═", "═", "╝",},
        };
    }
}
