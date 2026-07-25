using AcademiaX.Core.Common;
using AcademiaX.Core.Enums;

namespace AcademiaX.Core.Entities {
    public class Semester : BaseEntity {
        public SemesterType SemesterType { get; set; }

        public int AcademicYear { get; set; }

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public DateOnly RegistrationStartDate { get; set; }

        public DateOnly RegistrationEndDate { get; set; }

        public SemesterStatus Status { get; set; }

        // Navigation Properties

        public ICollection<CourseOffering> CourseOfferings { get; set; } = new List<CourseOffering>();
    }
}