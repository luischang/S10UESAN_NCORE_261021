using AutoMapper;
using S10UESAN_NCORE.Domain.Core.DTOs;
using S10UESAN_NCORE.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10UESAN_NCORE.Domain.Infrastructure.Mappings
{
    public class AutomapperProfile: Profile
    {

        public AutomapperProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();
            CreateMap<CustomerCountryDTO, Customer>();
            CreateMap<Customer, CustomerCountryDTO>();
        }


    }
}
