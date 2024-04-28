using System;
using AutoMapper;

namespace WDC.Products.Core.Mapping.CustomerMapping
{
    public partial class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateCustomerMapping();
            UpdateCustomerMapping();
            GetCustomerListMapping();
        }
    }
}

