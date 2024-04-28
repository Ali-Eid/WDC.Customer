using System;
using MediatR;
using WDC.Customers.Core.Bases.ResponseBase;

namespace WDC.Products.Core.Features.CustomerFeatures.Command.Models
{
    public class DeleteCustomerCommand : IRequest<Response<string>>
    {
        public int CustomerId { get; set; }

        public DeleteCustomerCommand(int CustomerId)
        {
            this.CustomerId = CustomerId;
        }
    }
}

