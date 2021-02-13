using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingExamples
{
    class Rectangle : BaseFigure
    {
        public override void Draw(int startX, int startY)
        {
            int width = 20;
            int height = 15;

            //for (int x = startX; x < startX + width; x++)
            //{
            //    for (int y = startY; y < startY + height; y++)
            //    {
            //        Console.SetCursorPosition(x, y);
            //        Console.Write(Symbol);
            //    }
            //}

            int x = startX;

            while (x < startX + width)
            {
                int y = startY;
                while (y < startY + height)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(Symbol);
                    y++;
                }
                x++;
            }
        }
    }
}
