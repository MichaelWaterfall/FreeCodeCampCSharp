// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int heroHealth = 10;
int monsterHealth = 10;

Random attack = new Random();
int heroAttack = attack.Next(1, 10);
int monsterAttack = attack.Next(1, 10);

do {
    monsterHealth -= heroAttack;
    Console.WriteLine($"Monster was damaged and lost {heroAttack} and now has {monsterHealth} health");
    heroHealth -= monsterAttack;
    Console.WriteLine($"Hero was damaged and lost {monsterAttack} and now has {heroHealth} health");
} while(heroHealth <= 0 || monsterHealth <= 0); 

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");