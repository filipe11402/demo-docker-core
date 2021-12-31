using products_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace products_core.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<ProductModel> _products;

        public ProductRepository()
        {
            this._products = new List<ProductModel>()
            {
                new ProductModel(Guid.NewGuid().ToString(), "Paper", 20),
                new ProductModel(Guid.NewGuid().ToString(), "Mouse", 60),
                new ProductModel(Guid.NewGuid().ToString(), "Cat Litter", 5),
                new ProductModel(Guid.NewGuid().ToString(), "Food", 100),
            };
        }

        public List<ProductModel> GetProducts()
        {
            return this._products;
        }
    }
}
