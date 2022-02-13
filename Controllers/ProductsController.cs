using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using products_core.Mediator.Queries;
using products_core.Models;
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
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [Route("list")]
        [HttpGet]
        public async Task<IActionResult> FetchProducts()
        {
            return StatusCode(StatusCodes.Status200OK,
                              await this._mediator.Send(new GetProductListQuery()));
        }
    }
}
