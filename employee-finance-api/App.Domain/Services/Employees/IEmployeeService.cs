using App.Common.Classes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Employees
{
    public interface IEmployeeService
    {
        Task<ResponseContract<List<EmployeeContract>>> GetEmployeeList();
        Task<ResponseContract<EmployeeContract>> GetEmployeeList(int id);
    }
}
