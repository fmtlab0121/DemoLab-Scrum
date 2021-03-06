using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultipleProject.Models;
using MultipleProject.Models.Contracts;

namespace MultipleProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;

        public CustomersController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        [HttpGet("test")]
        public ActionResult<string> TestOnline()
        {
            return Ok(_repoWrapper.Customers.Hello());
        }

        [HttpGet]
        public ActionResult<List<Customer>> GetAll()
        {
            return Ok(_repoWrapper.Customers.FindAll().ToList());
        }

        [HttpGet("add")]
        public IActionResult AddCustomer()
        {
            var customer = new Customer();
            customer.Name = $"Name{DateTime.Now.ToString("hhmmssff")}";
            _repoWrapper.Customers.Create(customer);
            _repoWrapper.Save();
            return Ok();
        }


    }
}