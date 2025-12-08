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

        public void GetAllStudents()
        {
            foreach (var s in studentsList)
            {
                Console.WriteLine($"Name: {s.Name}, ID: {s.Id}");
            }
        }

        public void Remove(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                throw new ArgumentException("Student list cannot be null or empty", nameof(students));
            }
            foreach (var student in students)
            {
                studentsList.Remove(student);
            }
            Console.WriteLine("Remove is Succesfully");
        }
    }
}
