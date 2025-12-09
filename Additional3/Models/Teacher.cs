using Additional3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional3.Models
{
    public class Teacher : IPerson
    {
        // List<Teacher> teachers = new List<Teacher>();
        public string Name { get; set; }
        private static int teacherCount = 0;
        public int Id { get; set; }
        public Teacher(string name)
        {
            Name = name;
            Id = ++teacherCount;
        }
        public void ShowAll()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}");
        }

        private static List<Teacher> teachersList = new List<Teacher>();

        //public static List<Teacher> Add(Teacher teacher)
        //{
        //    if (teacher == null)
        //    {
        //        throw new ArgumentNullException(nameof(teacher), "Teacher cannot be null");
        //    }

        //    teachersList.Add(teacher);
        //    return teachersList;
        //}


        public static string GetAllTeachers()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var s in teachersList)
                sb.AppendLine(s.Name);

            return sb.ToString();
        }

    }
}
