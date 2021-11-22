using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeShapesApp
{
    class ShapeMaker
    {
        private IShape _circle;
        private IShape _rectangle;
        private IShape _triangle;

        public ShapeMaker()
        {   }

        public void DrawCircle(double radius)
        {
            _circle = new Circle(radius);
            _circle.Draw();
        }
        public void DrawRectangle(double width, double length)
        {
            _rectangle = new Rectangle(width, length);
            _rectangle.Draw();
        }
        public void DrawTriangle(double l1, double l2, double l3)
        {
            _triangle = new Triangle(l1, l2, l3);
            _triangle.Draw();
        }
    }
}
