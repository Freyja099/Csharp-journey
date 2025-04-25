namespace CSharpExercises.Unit1;
{
    public static class stringInterpolation 
    {
        public static void RunExercise()
        {
            /* String  interpolation is used when you need to combine many literal strings and variables into a sigle formatted message */

            string greeting = "hey";
            string firstname = "Bob";

            string  message = $"{greeting} {firstname}" ;
            
            Console.WriteLine(message);

            /* We can also use string interpolation with multiple variables and literal  strings. */
            int version = 11 ;
            string updateText = "Update to Windows"  ;
            string message  = $" {updateText} {version}";
            Console.WriteLine(message);

            /* It's always better to avoid intermediate variables */

            int version = 11 ;
            string updateText = "Update to Windows"  ;

            Console.WriteLine($"{updateText} {version} ! ");

            /* We can also combine verbatim (@) literals and string interpolation  */

            string file = "Program x86" ;
            Console.WriteLine($@" C:\user\zouja\{file}\data");
        }
    }
}