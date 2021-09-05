using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_TaskAPI.Models;

namespace Technical_TaskAPI.Services
{
    public class CustomerService : ICustomer
    {
        CustomerDBContext db = new CustomerDBContext();
        public Customer CreateCustomer(Customer customer)
        {
           var LastRecord = db.Customers.Max(e => e.CustomerId);
            customer.CustomerId = LastRecord + 1;
            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(int id)
        {
           var customer =  db.Customers.Where(e => e.CustomerId == id).FirstOrDefault();
            db.Customers.Remove(customer);
            db.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customer GetCustomer(int id)
        {
            return db.Customers.Find(id);
        }

        public Customer UpdateCustomer(int id, Customer customer)
        {
            var editcustomer=GetCustomer(id);
            editcustomer.CustomerEmail = customer.CustomerEmail;
            editcustomer.CustomerAddress = customer.CustomerAddress;
            editcustomer.CustomerName = customer.CustomerName;
            editcustomer.CustomerPhone = customer.CustomerPhone;

            db.SaveChanges();
            return customer;
        }
    }
}
