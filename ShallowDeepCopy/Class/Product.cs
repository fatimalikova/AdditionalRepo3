using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShallowDeepCopy.Class
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product Details { get; set; }
        public Product ShallowCopy()
        {
            var ProductClass=  (Product)this.MemberwiseClone();
            ProductClass.Details = new Product()
            {
                Id = this.Details.Id,
                Name = this.Details.Name,
                Price = this.Details.Price
            };
            return ProductClass;
        }

        public Product DeepCopy()
        {
            var ProductClass = JsonSerializer.Deserialize<Product>(JsonSerializer.Serialize(this));
            return ProductClass;
        }
    }
}
