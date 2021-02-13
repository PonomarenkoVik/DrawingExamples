using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DrawingExamples
{
    public static class Executor
    {
        public static void Execute(List<IDraw> figures)
        {
            foreach (var fig in figures)
            {
                Thread.Sleep(2000);
                Console.Clear();
                if (fig == null)
                {
                    Console.WriteLine("No figure");
                    continue;
                }
                fig.Draw(10, 10);
            }
        }
    }
}
