using PracticeList.Class;
using PracticeList.Interface;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

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

            //Type type = typeof(Myclass);
            //Type type1 = typeof(MyEnum);
            //Console.WriteLine(type1.IsEnum);


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

            //var instance = Activator.CreateInstance(type, 23, "Leila") as Myclass;
            //Console.WriteLine(instance.Name);
            //Console.WriteLine(instance.Id);


            //MethodInfo method = type.GetMethod("Info");
            //method.Invoke(instance, [ 5, "Test" ]);

            //type.GetField("Id", BindingFlags.Public | BindingFlags.Instance).SetValue(instance, 45);
            //Console.WriteLine(instance.Id);


            Fatima leila = new Fatima(1, "Fatimaaaaaaaaaa", "Mammadova");
            Validate(leila);
            Fatima fatima1 = new Fatima(2, "Leila", "Aliyeva");
            Validate(fatima1);

            Myclass myclass = new Myclass();
            myclass.Id = Console.ReadLine() != null ? Convert.ToInt32(Console.ReadLine()) : 0;
            myclass.Name = (Name)Enum.Parse(typeof(Name), Console.ReadLine());
            myclass.Info(myclass.Id, myclass.Name);
            Console.ReadLine();

        }
        public static void Validate(object obj)
        {
            Type type = obj.GetType();
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var att = property.GetCustomAttribute<MyMaxLengthAttribute>();
                var value = property.GetValue(obj) as string;
                if (att != null && value != null && value.Length > att.Length)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{property.Name} maksimum uzunlugu kecir");
                    Console.ResetColor();
                }
            }
        }
        //public void Validate(object obj)
        //{
        //    Type type = obj.GetType();
        //    PropertyInfo[] properties = type.GetProperties();
        //    foreach (var property in properties)
        //    {
        //        var requiredAttribute = property.GetCustomAttribute<RequiredAttribute>();
        //        if (requiredAttribute != null)
        //        {
        //            var value = property.GetValue(obj);
        //            if (value == null || (value is string str && string.IsNullOrWhiteSpace(str)))
        //            {
        //                Console.WriteLine($"{property.Name} is required.");
        //            }
        //        }
        //        var maxLengthAttribute = property.GetCustomAttribute<MaxLengthAttribute>();
        //        if (maxLengthAttribute != null)
        //        {
        //            var value = property.GetValue(obj) as string;
        //            if (value != null && value.Length > maxLengthAttribute.Length)
        //            {
        //                Console.WriteLine($"{property.Name} exceeds maximum length of {maxLengthAttribute.Length}.");
        //            }
        //        }
        //    }
        //}

        


    }

    class Myclass
    {
        public int Id;
        [Required]
        [MaxLength(10)]
        private readonly Name _Name;
        public Name Name
        {
            get { return _Name; }
            set
            {
                if(!Enum.IsDefined(typeof(Name), value))
                {
                    throw new ArgumentException("Invalid Name value");
                }
            }
        }
        public Myclass()
        {
            
        }
        public Myclass(int id, Name name)
        {
            Id = id;
            Name = name;
        }
       
        public void Info(int id, Name name)
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
    enum Name
    {
        Fatima,
        Leila,
        Aysel,
        Jala
    }

    class MaxLengthAttribute : Attribute
    {
        public int Length { get; }
        public MaxLengthAttribute(int length)
        {
            Length = length;
        }
    }

    class Fatima
    {
        public int Id { get; set; }
        [Required]
        [MyMaxLength(10)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public Fatima(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public void Test()
        {
            Console.WriteLine("Fatima Test Method");

        }

        public void Info()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Surname: {Surname}");
        }
    }

    public class MyMaxLengthAttribute : Attribute
    {
        public int Length { get; }
        public MyMaxLengthAttribute(int length)
        {
            Length = length;
        }
    }
}
