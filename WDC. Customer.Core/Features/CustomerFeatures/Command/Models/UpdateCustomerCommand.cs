using System;
using MediatR;
using WDC.Customers.Core.Bases.ResponseBase;

namespace WDC.Products.Core.Features.CustomerFeatures.Command.Models
{
    public class UpdateCustomerCommand : IRequest<Response<string>>
    {
        public int CustomerId { get; set; }

        public required string Name { get; set; }

        public int Age { get; set; }

        public  string? Address { get; set; }

    }
}

