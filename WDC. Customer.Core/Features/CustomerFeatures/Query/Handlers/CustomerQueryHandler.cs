using System;
using AutoMapper;
using MediatR;
using WDC.Customers.Core.Bases.ResponseBase;
using WDC.Customers.Service.CustomerServices;
using WDC.Products.Core.Features.CustomerFeatures.Query.Models;
using WDC.Products.Core.Features.CustomerFeatures.Query.Responses;

namespace WDC.Products.Core.Features.CustomerFeatures.Query.Handlers
{
    public class CustomerQueryHandler : ResponseHandler , IRequestHandler<GetCustomerListQuery, Response<List<CustomerResponse>>>,
                                                         IRequestHandler<GetCustomerByIdQuery, Response<CustomerResponse>>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;
        public CustomerQueryHandler(IMapper mapper , ICustomerService customerService)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public async Task<Response<List<CustomerResponse>>> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
        {
            var customers = await _customerService.GetCustomersListAsync();
            var customersMapping = _mapper.Map<List<CustomerResponse>>(customers);
            return Success(customersMapping);
        }

        public async Task<Response<CustomerResponse>> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer =  _customerService.GetCustomerById(request.CustomerId);
            if (customer == null) return NotFound<CustomerResponse>("The customer is not exist");
            var customerMapping = _mapper.Map<CustomerResponse>(customer);
            return Success(customerMapping);
        }
    }
}

