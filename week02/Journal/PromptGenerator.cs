public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one habit I want to build, and how will it improve my life?",
        "Write a letter to your future self about what you are experiencing today.",
        "Imagine a conversation between your present self and your 10-year-old self. What would you say?",
        "What is one way I can show love or appreciation to someone I care about?",
    };

    List<string> _unusedPrompts;
    Random _random = new Random();

    public PromptGenerator()
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    public string GetRandomPrompt()
    {
        // Get a random index value and lookup the string in _prompts
        //Random rand = new Random();
        //int randomIndex = rand.Next(_prompts.Count); 
        //string prompt = _prompts[randomIndex]; 
       //Console.WriteLine($"Prompt: {prompt}");
       //Console.Write("> ");
       //return prompt;

       // stretch requirtement, cycle through all prompts beofre one gets repeated. 
       if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts);
        }

        int randomIndex = _random.Next(_unusedPrompts.Count);
        string selectedPrompt = _unusedPrompts[randomIndex];

         _unusedPrompts.RemoveAt(randomIndex);

         return selectedPrompt;

    }

}