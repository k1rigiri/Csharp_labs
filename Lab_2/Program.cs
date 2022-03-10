using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2 - Наследование");
            Console.WriteLine("Выполнил - Свиридов В.Д.");

            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник A",
                Width = 15.2,
                Height = 13.7
            };

            Rectangle b = new Rectangle()
            {
                Name = "Прямоугольник B",
                Width = 5.1,
                Height = 2.8
            };

            Square c = new Square()
            {
                Name = "Квадрат",
                side = 3
            };

            Trapeze d = new Trapeze()
            {
                Name = "Трапеция",
                height = 2,
                F_base = 2,
                S_base = 3
            };

            Triangle e = new Triangle()
            {
                Name = "Треугольник",
                height = 5,
                Base = 4
            };

            Circle f = new Circle()
            {
                Name = "Круг",
                radius = 4
            };

            Rhomb g = new Rhomb()
            {
                Name = "Ромб",
                diagonal_1 = 4,
                diagonal_2 = 5
            };

            Parall h = new Parall()
            {
                Name = "Параллелограмм",
                height = 4,
                Base = 2
            };

            Pentagon j = new Pentagon()
            {
                Name = "Правильный пятиугольник",
                side = 7
            };

            decagon k = new decagon()
            {
                Name = "Правильный десятиугольник",
                side = 10
            };

            //Выводим информацию
            Console.WriteLine();
            Console.WriteLine(" Название фигуры: {0}\n Площадь фигуры: {1}", a.Name, a.GetArea());
            Console.WriteLine("\n Название фигуры: {0}\n Площадь фигуры: {1}", b.Name, b.GetArea());
            Console.WriteLine("\n Название фигуры: {0}\n Площадь фигуры: {1}", c.Name, c.GetArea());
            Console.WriteLine("\n Название фигуры: {0}\n Площадь фигуры: {1}", d.Name, d.GetArea());
            Console.WriteLine("\n Название фигуры: {0}\n Площадь фигуры: {1}", e.Name, e.GetArea());
            Console.WriteLine("\n Название фигуры: {0}\n Площадь фигуры: {1}", f.Name, f.GetArea());
            Console.WriteLine("\n Название фигуры: {0}\n Площадь фигуры: {1}", g.Name, g.GetArea());
            Console.WriteLine("\n Название фигуры: {0}\n Площадь фигуры: {1}", h.Name, h.GetArea());
            Console.WriteLine("\n Название фигуры: {0}\n Площадь фигуры: {1}", j.Name, j.GetArea());
            Console.WriteLine("\n Название фигуры: {0}\n Площадь фигуры: {1}", k.Name, k.GetArea());
        }
    }
}
