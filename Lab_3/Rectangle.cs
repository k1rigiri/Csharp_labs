using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Rectangle : figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
