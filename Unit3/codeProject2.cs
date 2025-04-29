string? readInput;
string input = "";
bool isValidInput = false;


Console.WriteLine("Enter your role name : Administrator, User or Manager");
while(isValidInput == false)
{
    readInput = Console.ReadLine();

    if (readInput != null)
    {
        input = readInput.Trim();

        if (input.ToLower() == "administrator" || input.ToLower() == "user" || input.ToLower() == "manager")
        {
            isValidInput = true;
            
        }
       else
            Console.WriteLine($"The role {input} is not valid, please enter a valid role name : Administrator, User or Manager");
    }

    else
        Console.WriteLine("The role can't be empty, enter a valid role name ");
}

Console.WriteLine("You have entered a valid role name : " + input);