using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yHihg, int yLow, int x, char sym)
        {
            pList = new List<Point>();

            for(int i = yHihg; i<=yLow; i++)
            {
                Point p1 = new Point(x, i, sym);
                pList.Add(p1);
            }
        }

        
    }
}
