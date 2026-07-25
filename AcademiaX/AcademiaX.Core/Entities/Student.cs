using AcademiaX.Core.Enums;

namespace AcademiaX.Core.Entities {
    public class Student : Person {

        public string StudentNumber { get; set; } = string.Empty;

        public Guid AcademicProgramId { get; set; }

        public Guid AcademicLevelId { get; set; }

        public DateOnly AdmissionYear { get; set; }

        public Guid AdmissionSemesterId { get; set; }

        public decimal CurrentGPA { get; set; }

        public StudentStatus Status { get; set; }

        // Navigation Properties

        public AcademicProgram AcademicProgram { get; set; } = null!;

        public AcademicLevel AcademicLevel { get; set; } = null!;

        public Semester AdmissionSemester { get; set; } = null!;

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

        public ICollection<AssignmentSubmission> AssignmentSubmissions { get; set; } = new List<AssignmentSubmission>();


    }
}