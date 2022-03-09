using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public abstract class figure
    {
        public string Name { get; set; }
        public abstract double GetArea();
    }
}
