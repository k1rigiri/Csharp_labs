using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class decagon : figure
    {
        public double side { get; set; }
        public override double GetArea()
        {
            return 2.5 * side * side * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }
    }
}
