using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaX.Core.Entities {
    public abstract class Employee : Person {
        public string EmployeeNumber { get; set; } = string.Empty;

        public DateOnly HireDate { get; set; }

        public string? Office { get; set; }
    }
}
