// For my creativity portion, I made it to where it would always remove something that wasn't removed before in the HideRandomWords
// I also made it to where the user can select however many words they want it to hide each round, so that it can be customizable to their preference.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your scripture memorizer tool!");
        Console.WriteLine();
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Console.Write("Please input how many words you would like it to hide each round (ex. 1): ");
        string answer = Console.ReadLine();
        int wordsToHide = int.Parse(answer);
        Console.WriteLine();

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(wordsToHide);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}