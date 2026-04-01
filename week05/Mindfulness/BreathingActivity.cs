using System;

public class BreathingActivity : Activity
{
    public BreathingActivity():base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."){}

    public void Run()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(5);

            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.Write("\nBreathe out... ");
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndMessage();
    }
}