using App.Common.Classes.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;

namespace App.Web.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController()
        {

        }


        [HttpGet("getemployees")]
        public ResponseContract<List<EmployeeContract>> GetEmployeesList()
        {
            ResponseContract<List<EmployeeContract>> response = new ResponseContract<List<EmployeeContract>>();
            List<EmployeeContract> employees = new List<EmployeeContract>();
            response.Status = "success";
            response.Message = "Successfully! All records has been fetched.";

            EmployeeContract employee = new EmployeeContract {Id = 24, EmployeeName = "Tommy", EmployeeSalary = 15000000, EmployeeAge = 30, ProfileImage = "tommy.jpg"};
            employees.Add(employee);
            response.Data = employees;
            return response;
        }
    }
}
