using Capstone.DAO.Interfaces;
using Capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerDAO customerDAO;

        public CustomerController(ICustomerDAO petDAO)
        {
            this.customerDAO = petDAO;
        }

        [HttpGet]
        public ActionResult<List<Customer>> GetCustomers()
        {
            return Ok(customerDAO.GetCustomers());
        }

        [HttpGet("petId")]
        public ActionResult<Customer> GetCustomer(int petId)
        {
            return Ok(customerDAO.GetCustomer(petId));
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            bool result = customerDAO.AddCustomer(customer);

            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
