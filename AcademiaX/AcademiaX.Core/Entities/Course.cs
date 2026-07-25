using AcademiaX.Core.Common;
using AcademiaX.Core.Enums;

namespace AcademiaX.Core.Entities {
    public class Course : BaseEntity {
        public Guid AcademicProgramId { get; set; }

        public Guid AcademicLevelId { get; set; }

        public string CourseCode { get; set; } = string.Empty;

        public string NameEnglish { get; set; } = string.Empty;

        public string NameArabic { get; set; } = string.Empty;

        public string? Description { get; set; }

        public int CreditHours { get; set; }

        public CourseType CourseType { get; set; }

        // Navigation Properties

        public AcademicProgram AcademicProgram { get; set; } = null!;
        public AcademicLevel AcademicLevel { get; set; } = null!;
        public ICollection<CourseOffering> CourseOfferings { get; set; } = new List<CourseOffering>();
    }
}