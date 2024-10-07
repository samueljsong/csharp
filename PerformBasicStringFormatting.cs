/**
 * Escape sequences
 * 
 * \ --> is the escape sequence
 * To use quotations in strings use escape sequences 
 * 
 * The backslash is also reserved for escape sequence.
 * - To use escape sequences in strings use --> \\
 * - \n --> new line
 * - \t --> tab
 * 
 * Verbatim String Literal --> @
 * - will keep all whitespace and characters without the need of escape sequences
 */

 // Example of Verbatim String Literal
 Console.WriteLine(@"    c:\source\repos
            (this is where your code goes)");


/**
 * String Interpolation
 * - combines multiple values into a single string literal
 *
 * you can concatenate using the '+' operator
 * like javascript, you can use $"{variable}"
 *
 */

string name = "Samuel";

Console.WriteLine($"Your name is {name}");