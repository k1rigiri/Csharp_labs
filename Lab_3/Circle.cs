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
            return new Point((int)(Position.X + radius / 2), (int)(Position.Y + radius / 2));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color), Position.X - Convert.ToInt32(radius), Position.Y - Convert.ToInt32(radius), Convert.ToInt32(radius) + Convert.ToInt32(radius), Convert.ToInt32(radius) + Convert.ToInt32(radius));
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
