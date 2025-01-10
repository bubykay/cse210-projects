public class PromptGenerator
{
  public List<string> _prompts = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"
];

  public string GetRandomPrompt()
  {
    int _promptsLength = _prompts.Count;
    Random random = new();
    return _prompts[random.Next(0, _promptsLength)];
  }

  public void AddPrompt(string prompt)
  {
    _prompts.Add(prompt);
  }


}