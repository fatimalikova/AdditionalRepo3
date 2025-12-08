using Additional3.Interface;
using Additional3.Models;

namespace Additional3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //IPerson student1 = new Student("Alice");
            //IPerson student2 = new Student("Bob");
            //IPerson student = new Student("Charlie");
            //student.ShowAll();
            //student1.ShowAll();
            //student2.ShowAll();


            //IPerson teacher1 = new Teacher("Mr. Smith");
            //IPerson teacher2 = new Teacher("Ms. Johnson");
            //IPerson teacher = new Teacher("Dr. Brown");
            //teacher.ShowAll();
            //teacher1.ShowAll();
            //teacher2.ShowAll();

            Student student3 = new Student("David");
            Student.Add(student3);
            Console.WriteLine(Student.GetAllStudents());


            Teacher teacher3 = new Teacher("Prof. Green");
            Teacher.Add(teacher3);
            Console.WriteLine(Teacher.GetAllStudents());


        }
    }
}
