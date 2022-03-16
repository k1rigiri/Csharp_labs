using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Lab_3
{
    class Square : figure
    {
        public double side { get; set; }
        public override double GetArea()
        {
            return side * side;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + side / 2), (int)(Position.Y + side / 2));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)side, (int)side);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
