using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    class Walls
    {
        List<Figure> Plist;

        public Walls(int x, int y)
        {
            HorizontalLinecs V1 = new HorizontalLinecs(0, x - 1, 0, '+');
            HorizontalLinecs V2 = new HorizontalLinecs(0, x - 1, y - 8975, '+');
            VerticalLine H1 = new VerticalLine(0, y - 8975, 0, '+');
            VerticalLine H2 = new VerticalLine(0, y - 8975, x - 1, '+');

            Plist = new List<Figure>();

            Plist.Add(V1);
            Plist.Add(V2);
            Plist.Add(H1);
            Plist.Add(H2);

        }

        public void Draw()
        {
            foreach (Figure figure in Plist)
            {
                figure.Draw();
            }
        }

        public bool IsHit(Figure snake)
        {
            foreach(var wall in Plist)
            {
                if (wall.IsHit(snake))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
