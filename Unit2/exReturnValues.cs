namespace CSharpExercises.Unit2
{
public static class RandomDice{
    public static void RunExercise(){
        Random dice = new Random();
        int roll1 = dice.Next();
        int roll2 = dice.Next(101);
        int roll3 = dice.Next(50, 101);

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");
        }
    }
}
/* 
The first version of the Next() method doesn't set an upper and lower boundary, so the method will return values ranging from 0 to 2,147,483,647, which is the maximum value an int can store.

The second version of the Next() method specifies the maximum value as an upper boundary, so in this case, you can expect a random value between 0 and 100.

The third version of the Next() method specifies both the minimum and maximum values, so in this case, you can expect a random value between 50 and 100.
 */