## Collaboration
##### In one or two sentences, explain why the two classes directly collaborate and what information or behavior one supplies to the other.
These two classes collaborate to allow students the ability to reserve unavailable equipment items. The Student class supplies a student's information which
the Reservation class stores as part of a reservation object.

## Association
##### Which property or collection represents the association between the two objects?
The association between the two objects is represented by the Student property in the Reservation class and the Reservations list in the Student class.

## Multiplicity
##### Explain the multiplicity at each end of the UML association. How are these multiplicities represented in C#?
One student can have zero to many reservations, while each reservation is associated with one student. This is represented in C# by the use of properties
and lists. Properties which may signify a single object of a class and lists which may signify many objects of a class.

## Responsibility Trace
##### Identify one responsibility from each class. Name the UML operation and C# method that implement that responsibility.
The Student class is responsible for managing the count of reservations. This is implemented using the CurrentReservations() UML operation and by the
CurrentReservations() C# method. The Reservation class is responsible for setting reservations. This is implemented using the SetReservation() UML operation
and by the SetReservation() C# method.