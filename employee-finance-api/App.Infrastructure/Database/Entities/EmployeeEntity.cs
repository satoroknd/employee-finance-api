using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Database.Entities
{
    public class EmployeeEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("employee_name")]
        public string EmployeeName { get; set; }

        [Column("employee_salary")]
        public int EmployeeSalary { get; set; }

        [Column("employee_age")]
        public int EmployeeAge { get; set; }

        [Column("profile_image")]
        public string ProfileImage { get; set; }
    }
}
