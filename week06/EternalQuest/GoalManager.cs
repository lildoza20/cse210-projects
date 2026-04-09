using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine($"You are Level {GetLevel()}.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
        }
    }
    
    public void CreateGoal()
    {
        Console.WriteLine("\nThetypes of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }

        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nYour goals are:");
        for (int i = 0; i < _goals.Count; i += 1)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nThe goals are: ");
        for (int i = 0; i <_goals.Count; i += 1)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());

        int oldLevel = GetLevel();

        int pointsEarned = _goals[goalNumber - 1].RecordEvent();
        _score += pointsEarned;

        int newLevel = GetLevel();

        Console.WriteLine($"You earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_score} points.");

        if (newLevel > oldLevel)
        {
            Console.WriteLine($"*** CONGRATS!!! You have reached Level {newLevel}!! ***");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i += 1)
        {
            string[] parts = lines[i].Split(":");
            string goalType = parts[0];
            string[] goalParts = parts[1].Split("|");

            if (goalType == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]), bool.Parse(goalParts[3])));
            }

            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2])));
            }

            else if (goalType == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]), int.Parse(goalParts[3]), int.Parse(goalParts[4]), int.Parse(goalParts[5])));
            }
        }
    }

    public int GetLevel()
    {
        return (_score / 1000) + 1;
    }
}