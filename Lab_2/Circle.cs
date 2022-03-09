using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Circle : figure
    {
        public double radius { get; set; }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
