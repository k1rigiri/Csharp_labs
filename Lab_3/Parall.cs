using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Parall : figure
    {
        public double Base { get; set; }
        public double height { get; set; }
        public override double GetArea()
        {
            return Base * height;
        }
    }
}
