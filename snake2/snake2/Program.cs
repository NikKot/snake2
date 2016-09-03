﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake2
{
    class Program
    {
        static void Main(string[] args)
        {
             
            //отрисовываем рамочку

            HorizontalLinecs V1 = new HorizontalLinecs(0, Console.BufferWidth -1 , 0, '+');
            HorizontalLinecs V2 = new HorizontalLinecs(0, Console.BufferWidth - 1, Console.BufferHeight - 8975, '+');
            VerticalLine H1 = new VerticalLine(0, Console.BufferHeight - 8975, 0, '+');
            VerticalLine H2 = new VerticalLine(0, Console.BufferHeight - 8975, Console.BufferWidth - 1, '+');

            V1.Draw();
            V2.Draw();
            H1.Draw();
            H2.Draw();

            Point p = new Point(6, 5, '*');

            Snake snake = new Snake(p, 4, Direction.DOWN);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo Key = Console.ReadKey();
                    snake.HandleKey(Key.Key);
                }

                Thread.Sleep(100);
                snake.Move();

            }
        }
    }
}
