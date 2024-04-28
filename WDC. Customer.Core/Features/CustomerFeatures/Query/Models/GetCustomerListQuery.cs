using System;
using MediatR;
using WDC.Customers.Core.Bases.ResponseBase;
using WDC.Products.Core.Features.CustomerFeatures.Query.Responses;

namespace WDC.Products.Core.Features.CustomerFeatures.Query.Models
{
    public class GetCustomerListQuery : IRequest<Response<List<CustomerResponse>>>
    {
        
    }
}

