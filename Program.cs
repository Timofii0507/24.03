using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03
{
    class Program
    {
        public delegate void AgeDelegate(Person person);

        public static event AgeDelegate OnYoungest;
        public static event AgeDelegate OnOldest;

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Person[] people = new Person[]
            {
            new Person { FirstName = "John", LastName = "Doe", Age = 30 },
            new Person { FirstName = "Jane", LastName = "Doe", Age = 25 },
            };

            OnYoungest += person => Console.WriteLine($"Наймолодший: {person.FirstName} {person.LastName}, Вік: {person.Age}");
            OnOldest += person => Console.WriteLine($"Найстарший: {person.FirstName} {person.LastName}, Вік: {person.Age}");

            var youngest = people.OrderBy(p => p.Age).FirstOrDefault();
            var oldest = people.OrderByDescending(p => p.Age).FirstOrDefault();

            OnYoungest?.Invoke(youngest);
            OnOldest?.Invoke(oldest);

            Console.WriteLine($"Середній вік: {people.AverageAge():F2}");
        }
    }
}
