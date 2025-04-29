string? readResult;
string input = "";
int number = 0;
bool isValidInput = false;

Console.WriteLine("Enter an integer value between 5 and 10:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)

        input = readResult;

    isValidInput = int.TryParse(input, out number);

    if (isValidInput == true)
    {
        if (number <= 5 || number >= 10)
        {
            isValidInput = false;
            Console.WriteLine($"You entered {number}. The number must be between 5 and 10. Please try again.");
        }
        
    }
    else
        Console.WriteLine("Sorry you entered an invalid number");

} while (isValidInput == false);

Console.WriteLine($" Your input value ({number}) has been accepted.");

readResult = Console.ReadLine();