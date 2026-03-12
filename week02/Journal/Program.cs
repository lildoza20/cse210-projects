// I decided to exceed requirements by adding in a feature that marks when something gets saved or loaded to allow surety to the user that the program works.
// As well as adding an "else" that clarifies to the user what's necessary so that they don't run into errors

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choices (1-5):");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);

                Console.WriteLine("Entry added successfully.");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();

                Console.WriteLine("Journal displayed successfully.");
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);

                Console.WriteLine("Journal loaded successfully.");
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);

                Console.WriteLine("Journal saved successfully.");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Journal closed.");
                running = false;
            }
            else
            {
                Console.WriteLine("That is not a correct choice.");
                Console.WriteLine("");
            }
        }
        
    }
}