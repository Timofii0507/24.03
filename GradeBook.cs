using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }

        public Student(string name)
        {
            Name = name;
            Grades = new List<int>();
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
            GradeAdded?.Invoke(this, new GradeEventArgs(grade));
        }

        public delegate void GradeAddedDelegate(object sender, GradeEventArgs e);
        public event GradeAddedDelegate GradeAdded;
    }

    public class GradeEventArgs : EventArgs
    {
        public int Grade { get; }

        public GradeEventArgs(int grade)
        {
            Grade = grade;
        }
    }
}
