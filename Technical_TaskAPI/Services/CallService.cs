using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_TaskAPI.Models;

namespace Technical_TaskAPI.Services
{
    public class CallService : ICalls
    {
        CustomerDBContext db = new CustomerDBContext();
        public Call CreateCall(Call call)
        {
            db.Calls.Add(call);
            db.SaveChanges();
            return call;
        }

        public void DeleteCall(int id, int id_customer)
        {
            var call = db.Calls.Where(e => e.CallId == id&&e.CustomerId== id_customer).FirstOrDefault();
            db.Calls.Remove(call);
            db.SaveChanges();
        }

        public List<Call> GetAllCalls()
        {
            return db.Calls.ToList();
        }

        public List<Call> GetAllCallsByCustomerId(int id)
        {
            return db.Calls.Where(e =>e.CustomerId == id).ToList();
        }

        public Call GetCall(int id)
        {
            return db.Calls.Find(id);
        }

        public Call UpdateCall(int id, int id_customer, Call call)
        {
            var editCall = db.Calls.Where(e => e.CallId == id && e.CustomerId == id_customer).FirstOrDefault();
            editCall.CallDate = call.CallDate;
            editCall.CustomerId = call.CustomerId;
            db.SaveChanges();
            return call;
        }
    }
}
