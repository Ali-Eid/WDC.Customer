using System;
using AutoMapper;
using WDC.Customers.Data.Entities;
using WDC.Products.Core.Features.CustomerFeatures.Query.Responses;

namespace WDC.Products.Core.Mapping.CustomerMapping
{
    public partial class CustomerProfile : Profile
    {
        void GetCustomerListMapping()
        {
            CreateMap<Customer, CustomerResponse>();
        }
    }
}

