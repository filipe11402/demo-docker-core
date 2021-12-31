using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using products_core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace products_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        [Route("list")]
        [HttpGet]
        public async Task<IActionResult> FetchProducts() 
        {
            return StatusCode(StatusCodes.Status200OK,
                              this._productRepository.GetProducts());
        }
    }
}
