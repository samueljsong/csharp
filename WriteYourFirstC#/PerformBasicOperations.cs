/**
 * Perform addition with implicit data conversion
 * 
 * Just like other languages, when doing concatenation, if the first value is a string --> string concatenation
 * However, if it is a number --> Number operation
 *
 * Remember that when dividing int : 5 / 2 --> it will truncate = 2
 * 
 * Casting
 * 
 * You can add (type) infront of a number to cast it to that type
 * - This will happen before the calculation.
 */

 //Example Casting
 int first = 3;
 int second = 4;

 decimal valyue = (decimal)first + (decimal)second;