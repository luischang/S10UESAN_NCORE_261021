using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S10UESAN_NCORE.Domain.Core.DTOs;
using S10UESAN_NCORE.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S10UESAN_NCORE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        [HttpGet]
        [Route("GetCustomers")]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _customerRepository.GetCustomers();
            var customersList = new List<CustomerCountryDTO>();
            foreach (var item in customers)
            {
                var customerDTO = new CustomerCountryDTO()
                {
                    Id = item.Id,
                    //FirstName = item.FirstName,
                    LastName = item.LastName,
                    Country = item.Country,
                    //City = item.City,
                    //Phone = item.Phone
                };
                customersList.Add(customerDTO);
            }

            return Ok(customersList);

        }


    }
}
