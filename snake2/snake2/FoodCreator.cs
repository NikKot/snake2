using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    class FoodCreator
    {
        int MaxHeight;
        int MaxWeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int MaxHeight, int MaxWeight, char sym)
        {
            this.MaxHeight = MaxHeight;
            this.MaxWeight = MaxWeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, MaxHeight - 2);
            int y = random.Next(2, MaxWeight - 2);
            return new Point(x, y, sym);
         }

    }
}
