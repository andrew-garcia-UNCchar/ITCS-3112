# Assignment 9-1 Reflection

Replace each placeholder with two or three complete sentences. Use examples
from your finished code.

## 1. Data Transfer Object

In your own words, what is a DTO? Explain why `AuthService` returns a
`SessionTokenDto` instead of returning the entire `StaffAccount`. Include the
three values carried by the DTO.

A Data Transfer Object is an object used to transfer data between classes. AuthService returns a SessionTokenDto instead of the 
entire StaffAccount because the SessionTokenDto includes values relating to the scope of the confirmation, rather
than the entire object which has unrelated data such as password and permissions. 

## 2. C# Record

What code did you write to declare `SessionTokenDto` as a record? What
constructor and properties did C# create from that declaration?

The DTO was declared using a public sealed record SessionTokenDto(string Token, string Username, string DisplayName, 
given from Part 4D. C# creates a constructor that takes the three values and properties named Token, Username, and DisplayName. 

## 3. Sequence Diagram Message

Choose one numbered message from the sequence diagram. Identify the class that
sends it, the class that receives it, and the method call that implements it.

Message #4 FindByUsername(username). AuthService is the class that sends it. StaffRepository receives it. FindByUsername is the 
method call that implements it. 

## 4. Alternative Login Paths

Describe what the program does for an unknown username, an incorrect password,
and valid credentials.

For an unknown username and password, Authenticate throws InvalidCredentialExceptions and ConsoleUI displayed an unsuccessful
login message. With valid credentials, a SessionTokenDto is returned, and the Username, display name, and token are displayed.
