using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentProject
{
    public class Student
    {
        public Student()
        {
            Name = string.Empty;
            Age = 0;
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public bool EqualTo(Student other)
        {   
            return Name==other.Name &&  Age == other.Age;
        }
        public override string ToString()
        {
            return $"{Name} ({Age} éves)";
        }
    }
}
