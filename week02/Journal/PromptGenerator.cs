using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "Who did I help today?",
        "What did I learn today?",
        "What made me feel grateful today?",
        "What challenge did I face today?",
        "What made me smile today?",
        "What was something unexpected that happened today?",
        "How did I see God's hand in my life today?",
        "What is one thing I want to improve tomorrow?",
        "What was the most interesting thing I did today?",
        "Did I act like the person I want to become today?",
        "What was the strongest emotion I felt today?",
        "What is one goal I made progress on today?",
        "What conversation stood out to me today?",
        "What is one thing I am proud of today?",
        "What did I do for someone else today?",
        "What distracted me today?",
        "What gave me energy today?",
        "What drained my energy today?",
        "What is something I want to remember about today?"
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        return _prompts[index];
    }
}