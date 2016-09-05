using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    class Snake : Figure
    {

        Direction direction;

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;

            pList = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);

            Point NextStep = GetNextPoint();
            pList.Add(NextStep);

            tail.Clear();
            NextStep.Draw();

        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point NextStep = new Point(head);
            NextStep.Move(1, direction);
            return NextStep;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }

        }

        public Boolean Eat(Point Food)
        {
            Point head = GetNextPoint();

            if (head.IsHit(Food))
            {
                Food.sym = head.sym;
                pList.Add(Food);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsHitTial()
        {
            Point NextPoint = GetNextPoint();

            foreach (Point p in pList)
            {
                if (NextPoint.IsHit(p))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
