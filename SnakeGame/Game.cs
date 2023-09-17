using System;
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
                Levels.RenderScore(levelChoice);
                _snake.SnakeAutoMovement();
                if (Levels._food == false)
                {
                    Levels.SnakeFood();
                    Levels._food = true;
                }
                Console.SetCursorPosition(Levels._foodPosition[0], Levels._foodPosition[1]);
                Console.Write("¤");
                Thread.Sleep(Levels._difficulty);
            }
        }
    }
}
