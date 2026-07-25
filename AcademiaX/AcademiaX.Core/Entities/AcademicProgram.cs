using AcademiaX.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaX.Core.Entities {
    public class AcademicProgram : BaseEntity {
        public Guid DepartmentId { get; set; }

        public string Code { get; set; } = string.Empty;

        public string NameEnglish { get; set; } = string.Empty;

        public string NameArabic { get; set; } = string.Empty;

        public string? Description { get; set; }

        public int DurationYears { get; set; }

        // Navigation Properties
        public Department Department { get; set; } = null!;

        // Uncomment after creating Student and Course
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
