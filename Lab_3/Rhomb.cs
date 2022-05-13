using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Lab_3
{
    class Rhomb : figure
    {
        public double diagonal_1 { get; set; }
        public double diagonal_2 { get; set; }
        public override double GetArea()
        {
            return (diagonal_1 * diagonal_2) / 2;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y + diagonal_2 / 2));
        }
        public override void Draw(Graphics gr)
        {
            Point[] points = { new Point(Position.X, Position.Y), new Point(Position.X + (int)diagonal_1 / 2, Position.Y + (int)diagonal_2 / 2), new Point(Position.X, Position.Y + (int)diagonal_2), new Point(Position.X - (int)diagonal_1 / 2, Position.Y + (int)diagonal_2 / 2) };
            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
