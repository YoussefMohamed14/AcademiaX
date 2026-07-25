using AcademiaX.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaX.Core.Entities {
    public class AcademicLevel : BaseEntity {
        public int LevelNumber { get; set; }

        public string NameEnglish { get; set; } = string.Empty;

        public string NameArabic { get; set; } = string.Empty;

        public ICollection<Student> Students { get; set; } = new List<Student>();

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
