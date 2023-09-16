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
            bool _gamePlaying = true;
            Snake _snake = new Snake(5, 5);
            Levels.RenderLevel(levelChoice);
            while (_gamePlaying)
            {
                if (Console.KeyAvailable)
                {
                    _snake.MovementDirection();
                }
                Levels.RenderScore(levelChoice);
                _snake.SnakeAutoMovement();
                Thread.Sleep(500);
            } 
        }
    }
}
