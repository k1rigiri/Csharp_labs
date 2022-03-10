using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Trapeze : figure
    {
        public double height { get; set; }
        public double F_base { get; set; }
        public double S_base { get; set; }
        public override double GetArea()
        {
            return (height*(F_base + S_base))/2;
        }
    }
}
