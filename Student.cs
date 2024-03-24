using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    public class GradeBook
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DisplayHighestAverageGrade()
        {
            var highestAvgStudent = students
                .OrderByDescending(s => s.Grades.Average())
                .FirstOrDefault();

            if (highestAvgStudent != null)
            {
                Console.WriteLine($"Студент з найвищим середнім балом: {highestAvgStudent.Name}, Середній бал: {highestAvgStudent.Grades.Average():F2}");
            }
        }
    }
}