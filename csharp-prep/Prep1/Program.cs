using System;

class Program
{
    static void Main(string[] args)
    {   
        string first_Name;
        string last_Name;

        Console.WriteLine("Hello Prep1 World!");
    
        Console.Write("What is your first name? ");
        first_Name = Console.ReadLine();
        Console.Write("What is your last name? ");
        last_Name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_Name}, {first_Name} {last_Name}.");
    }
}
