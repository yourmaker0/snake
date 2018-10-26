using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine
    {
        List<Point> pList;
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();

            Point p1;
            for(int i = xLeft; i<=xRight; i++)
            {
                p1 = new Point(i,y,'*');
                pList.Add(p1);
            }
        }


        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
