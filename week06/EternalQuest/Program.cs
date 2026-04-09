// For my creativity portion of this activity, I added a leveling system to where every 1000 points equates to a new level and allows the user to get congrats for completing 
// their activities via a message. Also to avoid any potential errors I used | instead of , for separating in the files.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}