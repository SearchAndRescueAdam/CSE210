using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magicNumber = generator.Next(1,101);

        int userGuess = -1;

        while (userGuess != magicNumber) 
        {
            Console.Write("Guess a number: ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess > magicNumber) {
                Console.WriteLine("Guess Lower!");
            }
            else if ( userGuess < magicNumber) {
                Console.WriteLine("Guess Higher!");
            }
            else {
                Console.WriteLine("You are correct!");
            }
        }
    }
}
