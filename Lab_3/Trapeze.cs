using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Lab_3
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
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + (S_base / 2)), (int)(Position.Y - height / 2));

        }
        public override void Draw(Graphics gr)
        {
            double c = (S_base - F_base)/2;
            Point[] points = { new Point(Position.X, Position.Y), new Point(Position.X + (int)c, Position.Y - (int)height), new Point(Position.X + (int)c + (int)F_base, Position.Y - (int)height), new Point(Position.X + (int)S_base, Position.Y) };
            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
