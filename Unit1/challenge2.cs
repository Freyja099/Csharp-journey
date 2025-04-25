// Challenge 2 :

/* In this challenge, you'll write code that will use a formula to convert a temperature from degrees Fahrenheit to Celsius. You'll print the result in a formatted message to the user.

Enter the following code in the .NET Editor:

int fahrenheit = 94;

To convert temperatures in degrees Fahrenheit to Celsius, first subtract 32, then multiply by five ninths (5 / 9).

When you're finished, the message should resemble the following output:
The temperature is 34.444444444444444444444444447 Celsius.
 */

// * My answer

namespace CSharpExercises.Unit1;
{
    public static class challenge2 
    {
        public static void RunExercise()
        {

            int fahrenheit = 94;
            decimal result = ((decimal)fahrenheit - 32 ) * (5.0m/9);

            Console.WriteLine($"The temperature is : {result} Celsius.");

// Admittedly, it is preferred to not see so many values after the decimal point. Ideally the value would be formatted to a single value after the decimal point: 34.4.
// *  => for doing so we can add in front of the result :F2 
// ! No space between result and F2

        }
    }
}