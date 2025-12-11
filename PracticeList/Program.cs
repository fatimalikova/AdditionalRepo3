using PracticeList.Class;
using PracticeList.Interface;
using System.Reflection;

namespace PracticeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHumanResources humanResources = new PersonService();
            humanResources.Add(new Person { Id = 1, Name = "Leila" });
            humanResources.GetAll();

            //Myclass myclass = new Myclass() { Id = 5 };
            //Console.WriteLine(myclass.Id);
            //myclass.Id = 10; vere bilmersen çünkü init ile tanımlandı

            Type type = typeof(Myclass);
            Type type1= typeof(MyEnum);
            Console.WriteLine(type1.IsEnum);
            //Console.WriteLine(type.Name);
            //Console.WriteLine(type.FullName);
            //Console.WriteLine(type.IsValueType);
            //Console.WriteLine(type.IsEnum);
            //Console.WriteLine(type.IsGenericType);
            //Console.WriteLine(type.IsAbstract);
            //Console.WriteLine(type.IsSealed);
            //Console.WriteLine(type.IsClass);


            //MethodInfo methodinfo = type.GetMethod("Info");
            //ParameterInfo[] info = methodinfo.GetParameters();
            //Console.WriteLine(info.Length);
            //foreach (var item in info)
            //{
            //    Console.WriteLine("Parameter Name: " + item.Name);
            //    Console.WriteLine("Parameter Type: " + item.ParameterType);
            //}

            var instance = Activator.CreateInstance(type, 23, "Leila") as Myclass;
            //Console.WriteLine(instance.Name);
            //Console.WriteLine(instance.Id);


            MethodInfo method = type.GetMethod("Info");
            method.Invoke(instance, [ 5, "Test" ]);

        }

    }
    class Myclass
    {
        public int Id { get; init; } = 12;
        public string Name { get; init; }

        public Myclass(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Myclass()
        {
            
        }

        public void Info(int id, string name)
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
        }
    }
    enum MyEnum
    {
        First,
        Second,
        Third
    }
}
