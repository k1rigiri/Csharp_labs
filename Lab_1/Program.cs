using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1 - Инкапсуляция");
            Console.WriteLine("Выполнил - Свиридов В.Д.");

            //Создадим комплексные числа и присвоим значения
            //действительной и мнимой части
            complex a = new complex() { Real = 3, Imag = 0.5 };
            complex b = new complex() { Real = 2, Imag = 0.8 };
            
            Student Anton = new Student() { Name = "Anton", Surname = "Ivanov", Sex = "Male", age = 20, mark = 4.6 };
            Student Dmitry = new Student() { Name = "Dmitry", Surname = "Nagoev", Sex = "Male", age = 22, mark = 4.8 };
            //к числу а прибавим b
            a.Add(b);

            //из числа b вычтем a
            b.Substract(a);

            Console.WriteLine("\nСложение и вычитание:");
            //Выведем результат
            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);

            Console.WriteLine("\nУмножение и деление:");

            //число а умножим на b
            a.Multiply(b);

            //число а поделим на b
            b.Divide(a);

            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);

            Console.WriteLine("\nПервый студент:");
            Console.WriteLine(" Имя - {0}\n Фамилия - {1}\n Пол - {2}\n Возраст - {3}\n Оценка - {4}", Anton.Name, Anton.Surname, Anton.Sex, Anton.age, Anton.mark);
            Console.WriteLine("\nВторой студент:");
            Console.WriteLine(" Имя - {0}\n Фамилия - {1}\n Пол - {2}\n Возраст - {3}\n Оценка - {4}", Dmitry.Name, Dmitry.Surname, Dmitry.Sex, Dmitry.age, Dmitry.mark);
            Console.WriteLine("\nТеперь сложим студентов:\n");

            Anton.add(Dmitry);
            Console.WriteLine(" Имена - {0}\n Фамилии - {1}\n Пол - {2}\n Общий возраст - {3}\n Средняя оценка - {4}", Anton.Name, Anton.Surname, Anton.Sex, Anton.age, Anton.mark);
        }
    }
}