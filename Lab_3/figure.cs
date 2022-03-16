using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Lab_3
{
    public abstract class figure
    {
        public string Name { get; set; }
        public abstract double GetArea();
        public System.Drawing.Color Color { get; set; }
        public System.Drawing.Point Position { get; set; }
        public abstract System.Drawing.Point GetCenter();
        public abstract void Draw(Graphics gr);
    }
}
