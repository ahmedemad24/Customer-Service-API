using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Technical_TaskAPI.Models;



namespace Technical_TaskAPI.Services
{
    public interface ICustomer
    {
        List<Customer> GetAllCustomers();
        Customer CreateCustomer(Customer customer);
        Customer GetCustomer(int id);
        Customer UpdateCustomer(int id, Customer customer);
        void DeleteCustomer(int id);

    }
}
 

  
