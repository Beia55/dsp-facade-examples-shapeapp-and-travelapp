using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeShapesApp
{
    class Triangle : IShape
    {
        public double L1 { get; set; }
        public double L2 { get; set; }
        public double L3 { get; set; }

        public Triangle(double l1, double l2, double l3)
        {
            this.L1 = l1;
            this.L2 = l2;
            this.L3 = l3;
        }

        public void Draw()
        {
            Console.WriteLine("This triangle has: l1 -> " + this.L1 + ", l2 -> " + this.L2+" and l3 -> "+this.L3);
        }

    }
}
