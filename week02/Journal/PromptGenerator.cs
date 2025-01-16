using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        "What is one habit I want to build, and how will it improve my life?",
        "Write a letter to your future self about what you’re experiencing today.",
        "Imagine a conversation between your present self and your 10-year-old self. What would you say?",
        "What is one way I can show love or appreciation to someone I care about?",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}