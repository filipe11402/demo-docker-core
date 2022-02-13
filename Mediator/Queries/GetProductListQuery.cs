using MediatR;
using products_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace products_core.Mediator.Queries
{
    public class GetProductListQuery : IRequest<List<ProductModel>>
    {
    }
}
