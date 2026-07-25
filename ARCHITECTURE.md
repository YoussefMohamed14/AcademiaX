# Architecture Decisions

## Primary Keys
- Use Guid for all entities.

Reason:
Allows safe data synchronization and avoids exposing sequential IDs.

---

## Identity

Use ASP.NET Core Identity.

Reason:
Secure, extensible, and production-ready.

---

## Academic Structure

Faculty
→ Department
→ Academic Program
→ Student

Reason:
Supports multiple programs within a department.