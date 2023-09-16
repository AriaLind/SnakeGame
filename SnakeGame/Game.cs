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
            Levels.RenderLevel(levelChoice);
            Levels.RenderScore(levelChoice);
        }
    }
}
