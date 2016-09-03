using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    class HorizontalLinecs : Figure
    {

        public HorizontalLinecs(int xLeft, int xRight, int y, char sym)

        {
            pList = new List<Point>();

            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add(p);
            }
        }
    }
}
