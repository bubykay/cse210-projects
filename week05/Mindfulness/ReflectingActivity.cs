using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

class ReflectingActivity : Activity
{
  private readonly List<string> prompts =
      [
          "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---"
      ];

  private readonly List<string> questions = [
           "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
  ];
  public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
  {
  }
  public void Run()
  {

    ActivityDetail();
    int seconds = Duration();
    Random random = new();
    GetReady();
    Console.WriteLine("Consider the following prompt: ");
    Console.WriteLine("");
    Console.WriteLine(prompts[random.Next(prompts.Count)]);
    Console.WriteLine("");
    Console.WriteLine("When you have something in mind, press enter to continue.");
    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("Now ponder on each of the following questions as they relate to the experience.");
    Console.WriteLine("");
    Console.Write("You may begin in...");
    CountDown(5);
    Console.Clear();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    while (DateTime.Now < endTime)
    {
      Console.WriteLine();
      Console.Write("> ");
      Console.Write($"{questions[random.Next(questions.Count)]} ");
      Animate(5);
    }
    Console.WriteLine("");
    ActivityEnded(seconds, 5);
  }
}