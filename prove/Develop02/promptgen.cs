using System;

public class PromptGen
{
    public List<string> prompts = new List<string>
    {
        "What did you eat today?",
        "Did you have any plans today? How did it go?",
        "Who did you see today? What did you talk about?",
        "what was a wierd thing you saw today?"
    };
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }
}

