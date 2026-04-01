using System;
using System.Collections.Generic;

public class ExerciseActivity : Activity
{
    private List<string> _exercises = new List<string>
    {
        "Push-ups",
        "Squats",
        "Jumping Jacks",
        "Plank",
        "Lunges",
        "Wall Sit"
    };

    public ExerciseActivity():base("Exercise", "This activity will help you improve your fitness by guiding you through short exercise intervals and short rests."){}

    private string GetRandomExercise()
    {
        Random random = new Random();
        return _exercises[random.Next(_exercises.Count)];
    }

    public void Run()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string exercise = GetRandomExercise();

            Console.WriteLine($"\nYour exercise is: {exercise}");
            Console.Write("Begin in: ");
            ShowCountDown(3);

            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.Write($"\nDo {exercise} for: ");
            ShowCountDown(10);

            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.Write("\nRest for: ");
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndMessage();
    }
}