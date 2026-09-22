# Assignment 5-2-1 Reflection

## 1. Why Person Is Abstract
Identify the state and behavior shared by every role and explain why a generic
Person object would be incomplete.

Person is abstract because all people share an id, name, email, and the GetRoleDescription method. A generic person
object would be incomplete because it does not have a role. 
## 2. Why Administration Is an Interface
Explain why IParticipationAdministrator belongs to Teacher and
InstructorAssistant but not Student.

IParticipationAdministrator is interfaced to only Teacher and I.A. classes because the roles are allowed to manage the 
records. Students do not have or need administrative responsibilities.
## 3. Person Polymorphism
Trace one GetRoleDescription call from the Person loop variable to the runtime
role override.

In the person loop, the Person variable may reference a Student, Teacher, or I.A. instance. When called, the class-specific
override is issued.
## 4. Interface Polymorphism
Trace one RecordParticipation call through IParticipationAdministrator and state which concrete object performs it.

In the administrator loop, the variable is IParticipationAdministrator. When called, the Teacher or I.A. object performs
the operation.
## 5. Extending the Design
Identify what changed when InstructorAssistant was added and which loop bodies and repository methods remained unchanged.

When added, I.A. lead to the creation of a class and its inclusion in the people and administrators lists. 
No loop bodies or repository methods were changed.