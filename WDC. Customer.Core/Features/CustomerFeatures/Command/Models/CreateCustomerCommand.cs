using System;
using MediatR;
using WDC.Customers.Core.Bases.ResponseBase;
using WDC.Products.Core.Features.CustomerFeatures.Query.Responses;

namespace WDC.Products.Core.Features.CustomerFeatures.Command.Models
{
    public class CreateCustomerCommand : IRequest<Response<CustomerResponse>>
    {
        public required string Name { get; set; }

        public int Age { get; set; }

        public string? Address { get; set; }

    }
}

