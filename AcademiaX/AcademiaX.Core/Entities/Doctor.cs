using AcademiaX.Core.Enums;

namespace AcademiaX.Core.Entities {
    public class Doctor : Employee {
        public AcademicRank AcademicRank { get; set; }

        // Navigation properties 
        public ICollection<CourseOffering> CourseOfferings { get; set; }
    }
}