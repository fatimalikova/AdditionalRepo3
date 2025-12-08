using Additional3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional3.Models
{
    internal class Student : IPerson
    {
        public string Name { get; set; }
        public int Id { get; set; }

        private static int studentCount = 0;
        public Student(string name)
        {
            Name = name;
            Id = ++studentCount;

        }

        private static List<Student> studentsList = new List<Student>();
        public static List<Student> Add(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Student cannot be null");
            }
            studentsList.Add(student);
            return studentsList;
        }

        public void ShowAll()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}");
        }

        public static string GetAllStudents()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var s in studentsList)
                sb.AppendLine(s.Name);

            return sb.ToString();
        }

    }
}
