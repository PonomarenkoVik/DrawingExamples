using System;
using System.Collections.Generic;

namespace DrawingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<IDraw> figures = new List<IDraw>();

            for (int i = 0; i < 100; i++)
            {
                int figNumber = rnd.Next(0, 3);
                BaseFigure fig = BaseFigure.BuildFigure((Figures)figNumber);
                figures.Add(fig);
            }

            Executor.Execute(figures);
        }
    }
}
