using ShallowDeepCopy.Class;

namespace ShallowDeepCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Id = 1, Name = "Laptop", Price = 1500.00 };
            product1.Details = new Product() { Id = 2, Name = "Laptop Details", Price = 11.00 };

            Product product2 = product1.ShallowCopy();
            product2.Details.Name = "Smartphone";
            Console.WriteLine(product1.Details.Name);
            Console.WriteLine(product2.Details.Name);

            //Product product2 = product1.ShallowCopy();

            //product2.Details.Name = "Smartphone";
            //Console.WriteLine(product1.Details.Name);

            Product product3 = product1.DeepCopy();
            product3.Details.Name = "Tablet";
            Console.WriteLine(product1.Details.Name);

            Product product4 = product1;
            product4.Details.Name = "Monitor";
            Console.WriteLine(product1.Details.Name);
            Console.WriteLine(product3.Details.Name);
            Console.WriteLine(product4.Details.Name);

            Console.WriteLine();
        }
    }
}
