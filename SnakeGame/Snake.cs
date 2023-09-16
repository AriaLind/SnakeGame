using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Snake
    {
        int[] _snakePosition = new int[2]; //[0] = X [1] = Y
        Queue<int[]> _snakeTail = new Queue<int[]>();
        int _snakeLength = 5;
        int leftRight = 1;
        int upDown = 0;
        public Snake(int startX, int startY)
        {
            _snakePosition[0] = startX;
            _snakePosition[1] = startY;         
        }
        public void SnakeAutoMovement()
        {
            Console.SetCursorPosition(0, 22);  //Debug
            Console.Write("SnakePosBefore" + _snakePosition[0] + " " + _snakePosition[1]);  //Debug
            _snakeTail.Enqueue(_snakePosition);
            if (_snakeTail.Count == _snakeLength)
            {
                int[] removeTailHere = _snakeTail.Dequeue();
                Console.SetCursorPosition(0, 20);  //Debug
                Console.Write("RemoveTail " + removeTailHere[0] + " " + removeTailHere[1]);  //Debug
                Console.SetCursorPosition(removeTailHere[0], removeTailHere[1]);
                Console.Write("A");
            }
            Console.SetCursorPosition(0, 23);
            foreach (int[] i in _snakeTail) //Debug
            {
                Console.WriteLine(i[0] + " " + i[1]);
            }

            _snakePosition[0] += leftRight;
            _snakePosition[1] += upDown;
            Console.SetCursorPosition(0, 21);  //Debug
            Console.Write("SnakePosAfter " + _snakePosition[0] + " " + _snakePosition[1]);  //Debug
            Console.SetCursorPosition(_snakePosition[0], _snakePosition[1]);
            Console.Write("O");
            Console.SetCursorPosition(_snakePosition[0], _snakePosition[1]);
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
