using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_TaskAPI.Services;
using Technical_TaskAPI.Models;
using Microsoft.AspNetCore.Cors;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Technical_TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCorsImplementationPolicy")]

    public class CallsController : ControllerBase
    {
        private readonly ICalls _context;
        public CallsController(ICalls context)
        {
            _context = context;
        }
        // GET: api/<CallsController>
        [HttpGet]
        public IEnumerable<Call> Get()
        {
            return _context.GetAllCalls();
        }


        [HttpGet("GetAllCallsByCustomerId/{id}")]
        public IEnumerable<Call> GetAllCallsByCustomerId(int id)
        {
            return _context.GetAllCallsByCustomerId(id);
        }


        // GET api/<CallsController>/5
        [HttpGet("{id}")]
        public Call Get(int id)
        {
            return _context.GetCall(id);
        }

        // POST api/<CallsController>
        [HttpPost]
        public Call Post(Call call)
        {
            _context.CreateCall(call);
            return call;
        }

        // PUT api/<CallsController>/5
        [HttpPut("{id}")]
        public Call Put(int id,Call call)
        {
            _context.UpdateCall(id,call.CustomerId, call);
            return call;
        }

        // DELETE api/<CallsController>/5
        [HttpDelete("{id}/{id_customer}")]
        public void Delete(int id, int id_customer)
        {
            _context.DeleteCall(id, id_customer);
        }
    }
}
