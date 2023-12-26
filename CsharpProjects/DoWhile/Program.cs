﻿// See https://aka.ms/new-console-template for more information
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

//Code Project 1:
string? readResult;
bool validEntry = false;
int numericValue = 0;
bool validNumber = false;
Console.WriteLine("Please pick a number between 5 and 10: ");

do {
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);
    if(readResult != null) {
        
        if(numericValue >= 5 && numericValue <= 10) {
            validEntry = true;
            Console.WriteLine("Your input has been accpeted");
        } else {
            Console.WriteLine("Your input is invalid, please try again: ");
        }
    }
} while(validEntry == false);

//Code Project 2:
string? readResult2;
string roleName = "";
bool validEntry2 = false;

do {
    Console.WriteLine("Enter your role name (Administrator, Manager or User)");
    readResult2 = Console.ReadLine();

    if(readResult2 != null) {
        roleName = readResult2.Trim();
    }
    
      if(roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") {
        validEntry2 = true;

      } else {
        Console.WriteLine($"The role name you entered, {roleName} is not valid. Enter your role name");
      } 
} while(validEntry2 == false);

Console.WriteLine($"Your input value {roleName} has been accepted");