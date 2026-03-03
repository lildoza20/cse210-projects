using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();


        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number to add to the list (0 to quit): ");

            string  userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of the list is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the list is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The highest number in the list is: {max}");
        } 
    }
