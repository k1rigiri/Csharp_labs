using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;

namespace Lab_3
{
    class Decagon : figure
    {
        public double side { get; set; }
        public int Vertexes { set; get; } //Количество вершин
        public override double GetArea()
        {
            return 2.5 * side * side * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }
       public override Point GetCenter()
        {
            return new Point((int)(Position.X + side / 2), (int)(Position.Y + (side / 2) * (1 / Math.Tan(36 * Math.PI / 180))));
        }
        public override void Draw(Graphics gr)
        {
            var angle = Math.PI * 2 / Vertexes;
            var radius = (side / 2) / Math.Sin((180 / Vertexes) * Math.PI / 180);
            var points = Enumerable.Range(0, Vertexes).Select(i => PointF.Add(GetCenter(), new SizeF((float)Math.Sin(angle * i) * (float)radius, (float)Math.Cos(angle * i) * (float)radius)));
            gr.DrawPolygon(new Pen(Color), points.ToArray());
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
