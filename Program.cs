using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            var gradeBook = new GradeBook();

            var student1 = new Student("Олексій");
            student1.GradeAdded += OnGradeAdded;
            student1.AddGrade(12);
            student1.AddGrade(10);
            student1.AddGrade(8);

            var student2 = new Student("Марія");
            student2.GradeAdded += OnGradeAdded;
            student2.AddGrade(9);
            student2.AddGrade(7);
            student2.AddGrade(11);

            gradeBook.AddStudent(student1);
            gradeBook.AddStudent(student2);

            gradeBook.DisplayHighestAverageGrade();
        }

        private static void OnGradeAdded(object sender, GradeEventArgs e)
        {
            if (sender is Student student)
            {
                Console.WriteLine($"Додано оцінку {e.Grade} для студента {student.Name}");
            }
        }
    }
}