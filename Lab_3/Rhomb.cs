using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Rhomb : figure
    {
        public double diagonal_1 { get; set; }
        public double diagonal_2 { get; set; }
        public override double GetArea()
        {
            return (diagonal_1 + diagonal_2) / 2;
        }
    }
}
