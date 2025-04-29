/*
 Here are the rules for the battle game that you need to implement in your code project:
- You must use either the `do-while` statement or the `while` statement as an outer game loop.
- The hero and the monster start with 10 health points.
- All attacks are a value between 1 and 10.
- The hero attacks first.
- Print the amount of health the monster lost and their remaining health.
- If the monster's health is greater than 0, it can attack the hero.
- Print the amount of health the hero lost and their remaining health.
- Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
- Print the winner.
 */

int healthMonster = 10;
int healthHero = 10;
Random random = new Random();

do
{
    int randomHealth = random.Next(1, 11);

    healthMonster -= randomHealth;
    Console.WriteLine($"Hero attacks monster for {randomHealth} damage. Monster's health is now {healthMonster} .");

    if (healthMonster <= 0)
        continue;

    randomHealth = random.Next(1, 11);
    healthHero -= randomHealth;
    Console.WriteLine($"Monster attacks hero for {randomHealth} damage. Hero's health is now {healthHero} .");

}
while (healthMonster > 0 && healthHero > 0);

Console.WriteLine($" The winner is {(healthMonster > 0 ? "Monster" : "Hero")}");
