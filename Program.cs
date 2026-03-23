using System.ComponentModel;
using System.Formats.Asn1;

Console.WriteLine("Welcome to \"Buff People's Gym\" Website\n");
Console.WriteLine("To determine your payment plan (12 or 24 month plan), enter your age\n");

int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Age entered, would you like to see the 12 month or 24 month payment plan\n");

string? choice = Console.ReadLine();

if (age <= 5)
{
    Console.WriteLine("\nToo young to join the gym");
}

if (age >= 70)
{
    Console.WriteLine("\nToo old to join the gym");
}

if (age <= 13 && age > 5)
{
    if (choice == "12")
    {
        Console.WriteLine("\nSince you are still a child, you need your parent(s) to fill the application out for you, however, the payments are as follow:\n");
        Console.WriteLine("Age\t Price\t Payment Plan");
        Console.WriteLine($"{age}\t R279\t 12 x 12");
    }

    else if (choice == "24")
    {
        Console.WriteLine("\nSince you are still a child, you need your parent(s) to fill the application out for you, however, the payments are as follow:\n");
        Console.WriteLine("Age\t Price\t Payment Plan");
        Console.WriteLine($"{age}\t R199\t 12 x 24");
    }

    else
    {
        Console.WriteLine("Invalid choice, please enter either 12 or 24");
    }
}

if (age >= 13 && age < 18)
{
    if (choice == "12")
    {
        Console.WriteLine("\nYour age group can register for themselves and enjoy limited access to gym facilities\n");
        Console.WriteLine("Age\t Price\t Payment Plan");
        Console.WriteLine($"{age}\t R309\t 12 x 12");
    }

    else if (choice == "24")
    {
        Console.WriteLine("\nYour age group can register for themselves and enjoy limited access to gym facilities\n");
        Console.WriteLine("Age\t Price\t Payment Plan");
        Console.WriteLine($"{age}\t R229\t 24 x 24");
    }

    else
    {
        Console.WriteLine("Invalid choice, please enter either 12 or 24");
    }
}


if (age >= 18 && age < 60)
{
    if (choice == "12")
    {
        Console.WriteLine("\nYou will have full access to all facilities in the gym\n");
        Console.WriteLine("Age\t Price\t Payment Plan");
        Console.WriteLine($"{age}\t R399\t 12 x 12");
    }

    else if (choice == "24")
    {
        Console.WriteLine("\nYou will have full access to all facilities in the gym\n");
        Console.WriteLine("Age\t Price\t Payment Plan");
        Console.WriteLine($"{age}\t R329\t 24 x 12");
    }

    else
    {
        Console.WriteLine("Invalid choice, please enter either 12 or 24");
    }
}


if (age >= 60 && age < 70)
{
    if (choice == "12")
    {
        Console.WriteLine("\nYou will have full access to all facilities in the gym, however, you are required to have guides with you every step of the way\n");
        Console.WriteLine("Enjoy the benefits of elderly discounts");
        Console.WriteLine("Age\t Price\t Payment Plan");
        Console.WriteLine($"{age}\t R299\t 12 x 12");
    }

    else if (choice == "24")
    {
        Console.WriteLine("\nYou will have full access to all facilities in the gym, however, you are required to have guides with you every step of the way\n");
        Console.WriteLine("Enjoy the benefits of elderly discounts");
        Console.WriteLine("Age\t Price\t Payment Plan");
        Console.WriteLine($"{age}\t R259\t 24 x 24");
    }  

    else
    {
        Console.WriteLine("Invalid choice, please enter either 12 or 24");
    }
}