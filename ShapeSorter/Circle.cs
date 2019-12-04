using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSorter
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
