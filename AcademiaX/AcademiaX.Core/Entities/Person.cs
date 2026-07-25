using AcademiaX.Core.Common;
using AcademiaX.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaX.Core.Entities {
    public abstract class Person : BaseEntity {
        public Guid UserId { get; set; }

        public Guid DepartmentId { get; set; }

        public string NationalId { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string? MiddleName { get; set; }

        public string LastName { get; set; } = string.Empty;

        public DateOnly DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string Nationality { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string FullName {
            get {
                return string.Join(" ",
                    new[]
                    {
                    FirstName,
                    MiddleName,
                    LastName
                    }.Where(x => !string.IsNullOrWhiteSpace(x)));
            }
        }
    }
}
