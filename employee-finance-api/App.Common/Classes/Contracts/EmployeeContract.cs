using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Common.Classes.Contracts
{
    public class EmployeeContract
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("employee_name")]
        public string EmployeeName { get; set; }

        [JsonPropertyName("employee_salary")]
        public int EmployeeSalary { get; set; }

        [JsonPropertyName("employee_age")]
        public int EmployeeAge { get; set; }

        [JsonPropertyName("profile_image")]
        public string ProfileImage { get; set; }
    }
}
