using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst
{
    class Student
    {
        public static int count;
        public Student(string name)
        {
            this.Name = name;
            count++;
        }
        public string Name { get; set; }
    }
}

