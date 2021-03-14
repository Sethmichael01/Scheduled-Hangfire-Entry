using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFIRETest.Services
{
    public interface IEmployeeService
    {
        Task<bool> InsertEmployeeAsync();
    }
}
