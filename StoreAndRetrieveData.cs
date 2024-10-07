/**
 * Literal value: value that's constant and will never change --> Data Type: String
 * 
 * Datatypes
 * Char         --> 'a' use single quotation
 * Integer      --> 123
 * Float        --> 0.25F                           6-9 digits
 * Double       --> 2.345 Just make a decimal       15-17 digits
 * Decimal      --> 12.345566m                      28-29 digits
 * Boolean      --> true/false
 *
 * Declaring a variable 
 * first declare the data type of the variable, and then give it a name
 *
 * Variable name rules and conventions
 * - camelCase
 * - variables start with alpha numerics
 * - cannot use var without initializing the variable
*/

int age = 25;
string firstName = "Samuel";
string lastName = "Song";
bool isDeveloper = true;

Console.WriteLine("Name: " + firstName + " " + lastName + "\nAge: " + age + "\nDeveloper: " + isDeveloper);


/**
 * Implicitly typed local variables
 * 
 * Created by using 'var'
 * - tells the C# compiler that the data type is implied by the assigned value
 *
 * var message = "Hello";   --> Compiler will associate message as a String literal
 * - once assigned, cannot reassign to a different type.
 * 
 * 
*/