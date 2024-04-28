using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WDC.Customers.Api.Controllers.Base;
using WDC.Customers.Data.AppMetaData;
using WDC.Products.Core.Features.CustomerFeatures.Command.Models;
using WDC.Products.Core.Features.CustomerFeatures.Query.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WDC.Customers.Api.Controllers
{

    public class CustomerController : AppControllerBase
    {
        [HttpGet(Router.CustomerRouting.list)]
        public async Task<IActionResult> GetOrdersList()
        {
            return Ok(await Mediator.Send(new GetCustomerListQuery()));
        }
        [HttpGet(Router.CustomerRouting.customerById)]
        public async Task<IActionResult> GetOrderById([FromRoute] int Id)
        {
            return NewResult(await Mediator.Send(new GetCustomerByIdQuery(Id)));
        }
        [HttpPost(Router.CustomerRouting.create)]
        public async Task<IActionResult> CreateOrder([FromBody] CreateCustomerCommand command)
        {
            return NewResult(await Mediator.Send(command));
        }
        [HttpPut(Router.CustomerRouting.update)]
        public async Task<IActionResult> UpdateOrder([FromBody] DeleteCustomerCommand command)
        {
            return NewResult(await Mediator.Send(command));
        }
        [HttpDelete(Router.CustomerRouting.delete)]
        public async Task<IActionResult> DeleteOrder([FromRoute] int Id)
        {
            return NewResult(await Mediator.Send(new DeleteCustomerCommand(Id)));
        }
    }
}

