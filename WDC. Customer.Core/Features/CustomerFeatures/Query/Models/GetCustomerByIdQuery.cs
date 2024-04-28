using System;
using MediatR;
using WDC.Customers.Core.Bases.ResponseBase;
using WDC.Products.Core.Features.CustomerFeatures.Query.Responses;

namespace WDC.Products.Core.Features.CustomerFeatures.Query.Models
{
    public class GetCustomerByIdQuery : IRequest<Response<CustomerResponse>>
    {
        public int CustomerId { get; set; }

        public GetCustomerByIdQuery(int CustomerId)
        {
            this.CustomerId = CustomerId;
        }
    }
}

