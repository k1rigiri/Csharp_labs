using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Lab_3
{
    class Parall : figure
    {
        public double Base { get; set; }
        public double height { get; set; }
        public double side { get; set; }
        public override double GetArea()
        {
            return Base * height;
        }
        public override Point GetCenter()
        {
            double c = Math.Sqrt(Math.Pow(side, 2) - Math.Pow(height, 2));
            return new Point((int)(Position.X + (Base / 2) + c), (int)(Position.Y + height / 2));
            
        }
        public override void Draw(Graphics gr)
        {
            double c = Math.Sqrt(Math.Pow(side, 2) - Math.Pow(height, 2));
            Point[] points = { new Point(Position.X + (int)c, Position.Y + (int)height), new Point(Position.X + (int)c + (int)Base, Position.Y + (int)height), new Point(Position.X + (int)Base, Position.Y), new Point(Position.X, Position.Y) };
            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
