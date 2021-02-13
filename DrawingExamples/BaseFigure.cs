using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingExamples
{
    public enum Figures 
    { 
        None = 0,
        Rectangle = 1,
        Circle = 2
    }

    [Flags]
    public enum Ration
    {
        None =   0b0000,
        Wiskas = 0b0001,
        Water =  0b0010,
        Box =    0b0100,
        Paper =  0b1000,
    }

    public abstract class BaseFigure : IDraw
    {
        protected string Symbol = "*";
        public abstract void Draw(int x, int y);

        public static BaseFigure BuildFigure(Figures fig)
        {
            switch (fig)
            {
                case Figures.None:
                    return null;
                case Figures.Rectangle:
                    return new Rectangle();
                case Figures.Circle:
                    return new Circle();
                default:
                    return null;
            }
        }
    }
}
