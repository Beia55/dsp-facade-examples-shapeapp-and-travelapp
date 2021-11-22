using System;

namespace FacadeShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle(7.1);
            shapeMaker.DrawRectangle(6.5, 4.3);
            shapeMaker.DrawTriangle(9.8, 2.6, 10.0);
        }
    }
}
