namespace random

public static class Random{

    public static void RandomInt(){
        Random dice = new Random();  // or we can say just Random dice = new();
        int roll = dice.Next(1, 7);
        Console.WriteLine("You rolled a " + roll);
    }
    
}