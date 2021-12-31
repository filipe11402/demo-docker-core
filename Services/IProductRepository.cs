using products_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace products_core.Services
{
    public interface IProductRepository
    {
        List<ProductModel> GetProducts();
    }
}
