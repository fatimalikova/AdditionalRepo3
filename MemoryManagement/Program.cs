using System.Text.Json;

namespace MemoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CreateProduct();
           CreateProductAndReturn();
            GC.Collect();
           GC.WaitForPendingFinalizers();
        }

        public static void CreateProduct()
        {
            var product = new Product()
            {
                Name = "Laptop",
                Price = 5000,
                Details = new Product()
                {
                    Name = "16 GB RAM",
                    Price = 2000
                }
            };
        }
        public static Product CreateProductAndReturn()
        {
            var product = new Product()
            {
                Name = "Laptop",
                Price = 5000,
                Details = new Product()
                {
                    Name = "16 GB RAM",
                    Price = 2000
                }
            };
            return product.Details;
        }
    }
    public class Product
    {
        private static int Counter = 0;
        public string Name { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }

        public Product Details { get; set; }
        public Product()
        {
            Id = ++Counter;
        }
        ~Product()
        {
            Console.WriteLine($"Product with Id {Id} is being destroyed.");
        }

        public override string ToString()
        {
            return Id + " - " + Name + " - " + Price;
        }
    }
}
