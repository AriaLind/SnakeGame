﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeGame;

namespace SnakeGame
{
    internal class Game
    {
        public Game(int levelChoice)
        {
            Console.Clear();
            Levels.ChooseLevel(levelChoice);
            bool _gamePlaying = true;
            Snake _snake = new Snake(5, 5);
            Levels.RenderLevel();
            while (_gamePlaying)
            {
                Levels._score = _snake._snakeLength;
                if (Console.KeyAvailable)
                {
                    _snake.MovementDirection();
                }
                Levels.RenderScore();
                if (Levels._food == false)
                {
                    Levels.SnakeFood();
                    Levels._food = true;
                }
                Console.SetCursorPosition(Levels._foodPosition[0], Levels._foodPosition[1]);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("+");
                Console.ForegroundColor = ConsoleColor.White;
                _snake.SnakeAutoMovement();
                Thread.Sleep(Levels._speed);
                if (_snake._collided)
                {
                    _gamePlaying = false;
                }
            }
            Console.SetCursorPosition(Levels._allLevels[levelChoice].GetLength(1) / 2, Levels._allLevels[levelChoice].GetLength(0) / 2);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("GAME OVER.");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
