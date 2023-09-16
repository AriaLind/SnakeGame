using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Snake
    {
        int _snakePositionX;
        int _snakePositionY;
        Queue<int> _snakeTailPosX = new Queue<int>();
        Queue<int> _snakeTailPosY = new Queue<int>();
        public int _snakeLength = 3;
        int leftRight = 1;
        int upDown = 0;
        public Snake(int startX, int startY)
        {
            _snakePositionX = startX;
            _snakePositionY = startY;      
        }
        public void SnakeAutoMovement()
        {
            if (_snakeTailPosX.Count == _snakeLength)
            {
                int posX = _snakeTailPosX.Dequeue();
                int posY = _snakeTailPosY.Dequeue();
                Console.SetCursorPosition(posX, posY);
                Console.Write(" ");
            }
            _snakePositionX += leftRight;
            _snakePositionY += upDown;
            _snakeTailPosX.Enqueue(_snakePositionX);
            _snakeTailPosY.Enqueue(_snakePositionY);
            Console.SetCursorPosition(_snakePositionX, _snakePositionY);
            Console.Write("O");
            Console.SetCursorPosition(_snakePositionX, _snakePositionY);
        }
        public void Eat()
        {

        }
        public void MovementDirection()
        {
            var controlInput = Console.ReadKey(true);
            switch (controlInput.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (upDown < 2 && leftRight != 1)
                    {
                        leftRight = -1;
                        upDown = 0;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (upDown < 2 && leftRight != -1)
                    {
                        leftRight = 1;
                        upDown = 0;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (leftRight < 2 && upDown != -1)
                    {
                        upDown = 1;
                        leftRight = 0;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (leftRight < 2 && upDown != 1)
                    {
                        upDown = -1;
                        leftRight = 0;
                    }
                    break;
            }
        }
    }
}
