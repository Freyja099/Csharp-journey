namespace CSharpExercises.Unit1;
{
    public static class basicOperations 
    {
        public static void RunExercise()
        {
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

            /* For the quotient if it's defined as int the result will only show the integer it won't display the values after the decimal.
            To see divisions working properly we need to use a data type that supports fractional digits after the decimal point like decimal.
            Example :
            */
            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine($"Decimal quotient: {decimalQuotient}");

            // The output of the above code will be => Decimal quotient: 1.4

            /* Another solution is to perform a data type cast from int to decimal.
            Casting is one type of data conversion that instructs the compiler to temporarily treat a value as if it were a different data type. */

            int first = 7;
            int second = 5 ;
            decimal quotient= (decimal)first / (decimal)second;
            Console.WriteLine(quotient);
        }
    }
}