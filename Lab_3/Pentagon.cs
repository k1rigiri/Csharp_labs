using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Pentagon : figure
    {
        public double side { get; set; }
        public override double GetArea()
        {
            return (side*side *5)/(4 * 0.726542528);
        }
    }
}
