using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSorter
{
    public class Square : IShape
    {
        public double Side { get; set; }

        public double Length
        {
            get { return Side; }
        }

        public double Width
        {
            get { return Side; }
        }

        public double Area
        {
            get { return Math.Pow(Side, 2); }
        }

        public Square(double side)
        {
            Side = side;
        }
    }
}
