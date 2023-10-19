using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP_lab.Objects
{
    public class Subject
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public int HoursCount { get; set; }
        public Subject(string name, string teacher, int hours) 
        {
            Name = name;
            Teacher = teacher;
            HoursCount = hours;
        }
        public Subject() { }
    }
}
