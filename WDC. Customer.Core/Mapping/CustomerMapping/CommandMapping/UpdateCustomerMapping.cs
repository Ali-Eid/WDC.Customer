using System;
using AutoMapper;
using WDC.Customers.Data.Entities;
using WDC.Products.Core.Features.CustomerFeatures.Command.Models;

namespace WDC.Products.Core.Mapping.CustomerMapping
{
    public partial class CustomerProfile : Profile
    {
        void UpdateCustomerMapping()
        {
            CreateMap<UpdateCustomerCommand, Customer>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CustomerId));
        }
    }
}
