using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Square : figure
    {
        public double side { get; set; }
        public override double GetArea()
        {
            return side * side;
        }
    }
}
