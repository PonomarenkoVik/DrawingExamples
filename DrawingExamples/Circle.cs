using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingExamples
{
    public class Circle : BaseFigure
    {
        public override void Draw(int startX, int startY)
        {

            int centerX = 20, centerY = 10, radius = 8, x = -radius;
            while (x < radius)
            {
                var y = (int)Math.Floor(Math.Sqrt(radius * radius - x * x));

                DrawPoint(x + centerX, y + centerY);
                y = -y;
                DrawPoint(x + centerX, y + centerY);
                x++;
            }

        }

        private void DrawPoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Symbol);
        }
    }
}
