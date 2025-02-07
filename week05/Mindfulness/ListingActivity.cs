using System.Diagnostics;

class ListingActivity : Activity
{

  private readonly List<string> _prompt = new()
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
  };



  private readonly List<string> _lists;


  public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
  {
    _lists = [];

  }

  public void Run()
  {
    ActivityDetail();
    Console.WriteLine("");
    int seconds = Duration();
    Random random = new();
    GetReady();
    Console.WriteLine("");
    Console.WriteLine("List as many responses you can to the following prompt: ");
    Console.WriteLine("");
    Console.WriteLine(_prompt[random.Next(_prompt.Count)]);
    Console.Write("You may begin in...");
    CountDown(5);

    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    while (stopwatch.Elapsed.TotalSeconds < seconds)
    {
      Console.Write("> ");
      string list = Console.ReadLine();

      if (!string.IsNullOrWhiteSpace(list))
      {
        _lists.Add(list);
      }
    }
    stopwatch.Stop();

    Console.WriteLine("You listed the following: ");
    foreach (string list in _lists)
    {
      Console.WriteLine(list);
    }

    ActivityEnded(seconds, 10);
  }
}