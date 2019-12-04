using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSorter
{
    public class Rectangle
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public double Area
        {
            get { return Length * Width }
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
    }
}
