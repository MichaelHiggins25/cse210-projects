public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "What made you smile today?",
        "What was the best part of today?",
        "What was the hardest part of today?",
        "What did you learn today?",
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?"
    };

    private Random random = new Random();

    public string GetRandomPrompt()
    {
        return prompts[random.Next(prompts.Count)];
    }
}
