using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratory_2b
{
    class Circle
    {
        private double radius;

        public Circle()
        {

        }

        public double Radius { get => radius; set => radius = value >= 0 ? value : 0; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Square()
        {
            double square = radius * radius * Math.Round(Math.PI, 2);
            return square;
        }
        public double Length()
        {
            double length = 2 * radius * Math.Round(Math.PI, 2);
            return length;
        }

        public override string ToString()
        {
            return "\nCircle radius = " + this.Radius + "\nSquare = " + this.Square() +
                "\nLength = " + this.Length();
        }
    }
}
