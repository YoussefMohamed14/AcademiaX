using AcademiaX.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaX.Core.Entities {
    public class Faculty : BaseEntity {
        public string Code { get; set; } = string.Empty;

        public string NameEnglish { get; set; } = string.Empty;

        public string NameArabic { get; set; } = string.Empty;

        public string? Description { get; set; }

        public ICollection<Department> Departments { get; set; } = new List<Department>();
    }
}
