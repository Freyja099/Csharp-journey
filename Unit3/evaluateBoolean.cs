// Check equality and inequality using built-in helper methods

Console.WriteLine("a " == "a"); // false, the space at the end makes it different
Console.WriteLine("a" == "A"); // false, when comparing strings, the case matters

// To avoid this we can make sure that both the strings are upper-case or lower-case using the ToUpper() or ToLower() methods
// for the space we can use the Trim() method to delete all the unwanted spaces

string value1 = "a ";
string value2 = "A";

Console.WriteLine(value1.ToUpper().Trim() == value2); // true, now the comparison is case insensitive and the space is trimmed

// Some methods that return boolean values are: Contains(), StartsWith(), EndsWith(), Equals(), IsNullOrEmpty(), IsNullOrWhiteSpace(), etc.

string sentence = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(sentence.Contains("fox")); // true, the sentence contains the word "fox" 

// Logical negation
Console.WriteLine(sentence.Contains("fox") == false);
Console.WriteLine(!sentence.Contains("fox"));

// Conditional operator
int price = 100;
int discount = price > 150 ? 10 : 0; // if price is greater than 150, discount is 10, otherwise 0

Console.WriteLine($"The discount is {discount} %");
// or we can compact this code even more by eliminating the temporary variable discount
Console.WriteLine($"The discount is : {(price > 150 ? 10 : 0)} %");
