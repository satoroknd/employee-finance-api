using App.Common.Classes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {

        public EmployeeService()
        {

        }
        public Task<ResponseContract<List<EmployeeContract>>> GetEmployeeList()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContract<EmployeeContract>> GetEmployeeList(int id)
        {
            throw new NotImplementedException();
        }
    }
}
