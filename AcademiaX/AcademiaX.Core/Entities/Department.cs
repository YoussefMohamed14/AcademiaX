using AcademiaX.Core.Common;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AcademiaX.Core.Entities {
    public class Department : BaseEntity {

        public string Code { get; set; } = string.Empty;

        public string NameEnglish { get; set; } = string.Empty;

        public string NameArabic { get; set; } = string.Empty;

        public string? Description { get; set; }

        public Guid FacultyId { get; set; }

        // Navigation Properties

        public Faculty Faculty { get; set; } = null!;

        public ICollection<Student> Students { get; set; } = new List<Student>();

        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

        public ICollection<Course> Courses { get; set; } = new List<Course>();

        public ICollection<AcademicProgram> AcademicPrograms { get; set; } = new List<AcademicProgram>();


    }
}
