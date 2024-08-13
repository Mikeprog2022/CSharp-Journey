Console.WriteLine("Hello, World!");

Console.WriteLine(200);

Console.Write("This doesn't add a new line");

string valueRead = Console.ReadLine(); //Takes value read from console, only returns strings

//using System;

// uses Main method as entry point of the application

// public class Basics{
//     public static void Main(string[] args){
//         Console.WriteLine("This isn't using top level statements");
//         System.Console.WriteLine("This isn't using the system namespace");
//     }
// }

string stringVariableOne;
 stringVariableOne = "First Variable";

string stringVariableTwo = "Second Variable";

char charVariableOne = 'a';

//charVariableOne = 'bs'; to many characters

int intVariableOne = 0;

double decimalVariableOne = 1.2;

float decimalVariableTwo = 1.23f; // Less storage less accurate/precise

decimal decimalVariableThree = 1.23m; // More storage more precise

bool boolVariableOne = false;

++intVariableOne; //adds then returns

intVariableOne++; //returns then adds

double weight = 75.5; // "=" used to assign

int x = 5, y = 6, z = 8; // Different variables same type

x += 10; // is score = score + 10

string toBeConverted = "4";

int converted = Convert.ToInt32(toBeConverted);

string reverted = Convert.ToString(converted);

// ToBoolean: converts a type to a Boolean value
// ToChar:  converts a type to a char type
// ToDouble:  converts a type to a double type
// ToInt16, ToInt32, ToInt64: converts a type to a 16-bit, 32-bit and 64-bit int type accordingly
// ToString: converts a type to a string

Console.WriteLine("He said \"I am back!\""); // Use backslash as an escape character

Console.WriteLine(@"Hey!
I'm a verbatim string."); // Verbatim string allows special characters and linebreaks in strings

string toBeConcatenated1 = "C";

string toBeConcatenated2 = "#";

string concatenated = toBeConcatenated1 + toBeConcatenated2; // Concatenate strings with +

string toBeInterpolated = "hi";

Console.WriteLine($"{toBeInterpolated}");

Console.WriteLine(@$"{toBeInterpolated}: Hi ");

// equal to ==
// not equal to !=
// greater than >
// smaller than <
// greater or equal to >=
// smaller or equal to <=

bool conditional = true;

if (conditional)
{
    
}