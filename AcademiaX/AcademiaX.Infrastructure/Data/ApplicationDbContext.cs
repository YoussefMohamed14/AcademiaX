using AcademiaX.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AcademiaX.Core.Entities;

namespace AcademiaX.Infrastructure.Data {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid> {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }

        public DbSet<Faculty> Faculties => Set<Faculty>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<AcademicProgram> AcademicPrograms => Set<AcademicProgram>();
        public DbSet<AcademicLevel> AcademicLevels => Set<AcademicLevel>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Semester> Semesters => Set<Semester>();
        public DbSet<CourseOffering> CourseOfferings => Set<CourseOffering>();
        public DbSet<Enrollment> Enrollments => Set<Enrollment>();
    }
}
