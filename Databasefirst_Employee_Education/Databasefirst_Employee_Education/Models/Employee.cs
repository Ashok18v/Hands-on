using System;
using System.Collections.Generic;

namespace Databasefirst_Employee_Education.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeEducations = new HashSet<EmployeeEducation>();
         }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string EmployeeAddress { get; set; } = null!;

        public virtual ICollection<EmployeeEducation> EmployeeEducations { get; set; }
    }
}
