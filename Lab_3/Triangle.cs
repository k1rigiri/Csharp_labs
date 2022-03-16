using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Lab_3
{
    class Triangle : figure
    {
        public double height { get; set; }
        public double Base { get; set; }
        public override double GetArea()
        {
            return (Base * height) / 2;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Base / 2), (int)(Position.Y + height / 2));
        }
        public override void Draw(Graphics gr)
        {
            Point[] points = { new Point(Position.X,Position.Y), new Point(Position.X + Convert.ToInt32(Base), Position.Y), new Point((Position.X + Convert.ToInt32(Base))/2, Position.Y + Convert.ToInt32(height))};
            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
