using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yDown, int yUp, int x, char sym)
        {
            pList = new List<Point>();

            for (int i = yDown; i <= yUp; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }
    }
}
