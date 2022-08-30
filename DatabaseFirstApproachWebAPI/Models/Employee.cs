using System;
using System.Collections.Generic;

namespace DatabaseFirstApproachWebAPI.Models
{
    public partial class Employee
    {
        public int EmpIdId { get; set; }
        public string EmpName { get; set; } = null!;
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; } = null!;
    }
}
