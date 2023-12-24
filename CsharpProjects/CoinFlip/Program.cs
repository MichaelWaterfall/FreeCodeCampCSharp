// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random coin = new Random();
int coinFlip = coin.Next(0, 2);

Console.WriteLine(coinFlip == 0 ? "heads" : "tails");
Console.WriteLine(coinFlip);