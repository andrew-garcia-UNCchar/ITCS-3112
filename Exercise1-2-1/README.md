# Exercise 1-2-1 Reflection
## What is the name of the class definition used in this exercise?
Accumulator.

## What is the name of the object variable used in Program.cs?
myAccumulator.

## What is the name of the field used in Accumulator?
_total.

## What is the name of the property used in Accumulator?
Total.

## What is the name of the constructor that initializes the object?
Accumulator.

## What is the name of the method that changes the total?
Add.

## What starting state does the constructor establish?
The constructor establishes the starting state as the value of _total by using startingTotal.

## How does Add(5) change the object?
When called, the Add method increases the total amount by the inputted amount.

## Why can Program.cs read Total but not access _total directly?
Program.cs cannot access _total directly because the field is private, meaning it can only be access from
Accumulator.cs.

## Which of the four Object Oriented Principles did we practice and how?
Encapsulation, the use of private fields is for the purpose of preventing unwanted tampering of variables, ensuring the 
total value cannot be changed without having to change it in the Accumulator class directly.
