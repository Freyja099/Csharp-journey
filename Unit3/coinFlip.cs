Random number = new Random();
int randomNumber = number.Next(0, 2);

Console.WriteLine($"The random number {randomNumber}, the coin is on {(randomNumber == 0 ? "head" : "tails")} ");
