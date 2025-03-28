public class PromptGenerator
{
    private static Random _rand = new Random();
    public List<string> prompts = new List<string>() 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {

        //Get a random index value and lookup the string in _prompts
        int index = _rand.Next(prompts.Count);
        return prompts[index];
    }
}