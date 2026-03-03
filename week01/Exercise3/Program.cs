using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Guess My Number Game! In this game you will have to guess a number between 1 and 100, see how long it takes you!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        int count = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            count += 1;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
                Console.WriteLine($"You used {count} tries");
            }
        }
    }
}