using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_TaskAPI.Models;

namespace Technical_TaskAPI.Services
{
    public interface ICalls
    {
        List<Call> GetAllCalls();
        List<Call> GetAllCallsByCustomerId(int id );
        Call CreateCall(Call call);
        Call GetCall(int id);
        Call UpdateCall(int id,int id_customer, Call call);
        void DeleteCall(int id, int id_customer);
    }
}
