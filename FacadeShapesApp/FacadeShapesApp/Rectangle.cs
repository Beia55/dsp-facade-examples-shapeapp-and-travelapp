using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeShapesApp
{
    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }

        public void Draw()
        {
            Console.WriteLine("This rectangle has: width -> "+this.Width+" and length -> "+this.Length);
        }
    }
}
