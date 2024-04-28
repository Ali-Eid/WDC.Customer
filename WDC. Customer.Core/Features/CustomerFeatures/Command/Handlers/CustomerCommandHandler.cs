using System;
using AutoMapper;
using MediatR;
using WDC.Customers.Core.Bases.ResponseBase;
using WDC.Customers.Data.Entities;
using WDC.Customers.Service.CustomerServices;
using WDC.Products.Core.Features.CustomerFeatures.Command.Models;
using WDC.Products.Core.Features.CustomerFeatures.Query.Responses;

namespace WDC.Products.Core.Features.CustomerFeatures.Command.Handlers
{
    public class CustomerCommandHandler : ResponseHandler , IRequestHandler<CreateCustomerCommand, Response<CustomerResponse>>,
                                                           IRequestHandler<UpdateCustomerCommand, Response<string>>,
                                                           IRequestHandler<DeleteCustomerCommand, Response<string>>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;
        public CustomerCommandHandler(IMapper mapper, ICustomerService customerService)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public async Task<Response<CustomerResponse>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Customer>(request);
            var newCustomer = await _customerService.CreateCustomer(customer);
            var customerMapping = _mapper.Map<CustomerResponse>(newCustomer);
            return Success(customerMapping);
        }

        public async Task<Response<string>> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _customerService.GetCustomerById(request.CustomerId);
            if (customer == null) return NotFound<string>("The customer is not exist");

            var customerUpdate = _mapper.Map<Customer>(request);

            await _customerService.UpdateCustomer(customerUpdate);

            return Success<string>("Updated successfully");
        }

        public async Task<Response<string>> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _customerService.GetCustomerById(request.CustomerId);
            if (customer == null) return NotFound<string>("The customer is not exist");

            await _customerService.DeleteCustomer(customer);

            return Success<string>("Deleted successfully");
        }
    }
}

