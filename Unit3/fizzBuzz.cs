for(int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} FizzBuzz");
    

    else if (i % 5 == 0)
        Console.WriteLine($"{i} Buzz");

    else if (i % 3 == 0)
        Console.WriteLine($"{i} Fizz");
    else
        Console.WriteLine(i);
}

// ! Make sure to use the i%3 and i%5 before other conditions

