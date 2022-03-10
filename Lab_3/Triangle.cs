using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Triangle : figure
    {
        public double height { get; set; }
        public double Base { get; set; }
        public override double GetArea()
        {
            return (Base * height) / 2;
        }
    }
}
