using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Snake
    {
        int[] _snakePosition = new int[2];
        public Snake(int startX, int startY)
        {
            _snakePosition[0] = startX;
            _snakePosition[1] = startY;
        }
    }
}
