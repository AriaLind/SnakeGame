using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Snake
    {
        public int _snakePositionX;
        public int _snakePositionY;
        public bool _collided = false;
        List<int> _snakeTailPosX = new List<int>();
        List<int> _snakeTailPosY = new List<int>();
        public int _snakeLength = 1;
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
                int posX = _snakeTailPosX[0];
                int posY = _snakeTailPosY[0];
                _snakeTailPosX.RemoveAt(0);
                _snakeTailPosY.RemoveAt(0);
                Console.SetCursorPosition(posX, posY);
                Console.Write(" ");
            }
            _snakePositionX += leftRight;
            _snakePositionY += upDown;
            _snakeTailPosX.Add(_snakePositionX);
            _snakeTailPosY.Add(_snakePositionY);
            Console.SetCursorPosition(_snakePositionX, _snakePositionY);
            _collided = Levels.ObjectCollision(_snakePositionX, _snakePositionY);
            TailCollision();
            if (_collided == true)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            Console.SetCursorPosition(_snakePositionX, _snakePositionY);
            Eat();
        }
        public void Eat()
        {
            if (_snakePositionX == Levels._foodPosition[0] && _snakePositionY == Levels._foodPosition[1])
            {
                _snakeLength++;
                Levels._food = false;
            }
        }
        public void TailCollision()
        {
            if (_snakeTailPosX.Count == _snakeLength)
            {
                for (int i = 0; i < _snakeLength - 1; i++)
                {
                    if (_snakePositionX == _snakeTailPosX[i] && _snakePositionY == _snakeTailPosY[i])
                    {
                        _collided = true;
                        break;
                    }
                }
            }
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
