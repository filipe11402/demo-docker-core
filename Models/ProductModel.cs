using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace products_core.Models
{
    public class ProductModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductModel(string Id, string name, double price)
        {
            this.Id = Id;
            this.Name = name;
            this.Price = price;
        }
    }
}
