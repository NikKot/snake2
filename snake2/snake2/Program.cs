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
            Walls walls = new Walls(Console.BufferWidth, Console.BufferHeight);
            walls.Draw();

            Point p = new Point(6, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator FoodCreator = new FoodCreator(Console.BufferWidth - 1, Console.BufferHeight - 8975, '$');
            Point Food = FoodCreator.CreateFood();
            Food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTial())
                {
                    break;
                }

                if (snake.Eat(Food))
                {
                    snake.Draw();
                    Food = FoodCreator.CreateFood();
                    Food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo Key = Console.ReadKey();
                    snake.HandleKey(Key.Key);
                }
           }
        }
    }
}
