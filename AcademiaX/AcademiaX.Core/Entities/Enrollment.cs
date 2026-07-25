using AcademiaX.Core.Common;
using AcademiaX.Core.Enums;

namespace AcademiaX.Core.Entities {
    public class Enrollment : BaseEntity {
        public Guid StudentId { get; set; }

        public Guid CourseOfferingId { get; set; }

        public DateOnly EnrollmentDate { get; set; }

        public EnrollmentStatus Status { get; set; }

        // Navigation Properties

        public Student Student { get; set; } = null!;

        public CourseOffering CourseOffering { get; set; } = null!;
    }
}