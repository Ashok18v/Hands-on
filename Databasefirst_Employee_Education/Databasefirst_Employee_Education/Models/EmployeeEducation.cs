using System;
using System.Collections.Generic;

namespace Databasefirst_Employee_Education.Models
{
    public partial class EmployeeEducation
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = null!;
        public string? UniversityNmae { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}
