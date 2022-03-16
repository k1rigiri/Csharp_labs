using System;
using System.Windows.Forms;

namespace Lab_3
{
    class Program
    {
        public static figure[] figures =
        {
            new Rectangle()
            {
                Name = "Квадрат ",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(30, 30),
                Width = 100,
                Height = 50
            },

            new Circle()
            {
                Name = "Круг ",
                Color = System.Drawing.Color.Red,
                Position = new System.Drawing.Point(60, 150),
                radius = 40,
            },

            new Square()
            {
                Name = "Квадрат ",
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point(170, 20),
                side = 60,
            },

            new Triangle()
            {
                Name = "Треугольник ",
                Color = System.Drawing.Color.Orange,
                Position = new System.Drawing.Point(200, 150),
                height = 70,
                Base = 100,
            },

            new Parall()
            {
                Name = "Параллелограмм ",
                Color = System.Drawing.Color.Violet,
                Position = new System.Drawing.Point(300, 200),
                Base = 60,
                side = 70,
                height = 40
            },

            new Trapeze()
            {
                Name = "Трапеция ",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(400, 400),
                F_base = 40,
                S_base = 100,
                height = 40
            }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3 - Полиморфизм");
            Console.WriteLine("Выполнил - Свиридов В.Д.");

            /*figure r = new Rectangle()
            {
                Name = "Квадрат",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(30, 30),
                Width = 50,
                Height = 50
            };

            Console.WriteLine("Фигура: " + r.Name);
            Console.WriteLine("Площадь: " + r.GetArea());
            Console.WriteLine("Цвет: " + r.Color);
            Console.WriteLine("Положение фигуры: " + r.Position);
            Console.WriteLine("Координаты центра: " + r.GetCenter());*/

            Form form = new Form()
            {
                Text = "Лабораторная №3 - Полиморфизм",
                Size = new System.Drawing.Size(800, 600),
                StartPosition = FormStartPosition.CenterScreen
            };

            form.Paint += Form_paint;

            Application.Run(form);
        }

        private static void Form_paint(object sender, PaintEventArgs e)
        {
            foreach (figure f in figures)
            {
                f.Draw(e.Graphics);
            }
        }

        
    }
}
