using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80,25);

            HorizontalLine lineUp = new HorizontalLine(0,78,0,'*');
            HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '*');
            VerticalLine lineLeft = new VerticalLine(0, 24, 0, '*');
            VerticalLine lineRight = new VerticalLine(0, 24, 78, '*');
            lineUp.Draw();
            lineDown.Draw();
            lineLeft.Draw();
            lineRight.Draw();


            Console.ReadLine();

        }

       
       

    }
}
