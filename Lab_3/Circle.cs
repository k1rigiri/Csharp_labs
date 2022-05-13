using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Lab_3
{
    class Circle : figure
    {
        public double radius { get; set; }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + radius), (int)(Position.Y + radius));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color), Position.X, Position.Y, 2 * (int)radius, 2 * (int)radius);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
