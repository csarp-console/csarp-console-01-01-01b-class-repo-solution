using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentProject
{
    public static class StudentExtension
    {
        public static bool IsYounger(this Student student, Student other)
        {
            return student.Age < other.Age;
        }
    }
}
