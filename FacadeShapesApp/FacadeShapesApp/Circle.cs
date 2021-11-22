using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeShapesApp
{
    class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("This circle has: radius -> " + this.Radius);
        }
    }
}
