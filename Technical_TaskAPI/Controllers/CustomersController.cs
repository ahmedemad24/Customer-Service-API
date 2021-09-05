using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_TaskAPI.Models;
using Technical_TaskAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Technical_TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCorsImplementationPolicy")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomer _context;

        public CustomersController(ICustomer context)
        {
            _context = context;
        }
        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _context.GetAllCustomers();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _context.GetCustomer(id);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public Customer Post(Customer customer)
        {
           _context.CreateCustomer(customer);
            return customer;
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public Customer Put(int id, Customer customer)
        {
            _context.UpdateCustomer(id,customer);
            return customer;
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.DeleteCustomer(id);
        }
    }
}
