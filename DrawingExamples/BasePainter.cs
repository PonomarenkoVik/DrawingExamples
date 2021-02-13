using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingExamples
{
    public abstract class BasePainter : IDraw
    {
        public abstract void Draw(int x, int y);
    }
}
