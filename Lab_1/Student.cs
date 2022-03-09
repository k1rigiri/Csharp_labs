using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    class Student
    {
        public string Name { get; set; }
        public string Surname {get; set; }
        public string Sex { get; set; }
        public int age {get; set; }
        public double mark {get; set; }

        public void add(Student x)
        {
            Name = Name + "|" + x.Name;
            Surname += "|" + x.Surname;
            if (Sex.Equals(x.Sex))
                Sex = "Male";
            else
            {
                Sex = "разный";
            }
            age += x.age;
            mark = (mark + x.mark)/2;
        }
    }
}
