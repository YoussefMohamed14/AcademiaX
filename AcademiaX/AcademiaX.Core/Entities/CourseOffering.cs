using AcademiaX.Core.Common;
using AcademiaX.Core.Enums;

namespace AcademiaX.Core.Entities {
    public class CourseOffering : BaseEntity {
        public Guid CourseId { get; set; }

        public Guid DoctorId { get; set; }

        public Guid SemesterId { get; set; }

        public string Section { get; set; } = string.Empty;

        public int Capacity { get; set; }

        public CourseOfferingStatus Status { get; set; }

        // Navigation Properties

        public Course Course { get; set; } = null!;

        public Doctor Doctor { get; set; } = null!;

        public Semester Semester { get; set; } = null!;

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}