class Activity
{
  private readonly string _name;
  private readonly string _description;
  public string _option;

  public Activity(string name, string description)
  {
    _name = name;
    _description = description;
  }

  public Activity() : this("", "")
  {
  }

  public virtual void Start()
  {
    Console.Clear();
    Console.Write("Menu Options");
    Console.WriteLine(@"
    1. Start breathing activity
    2. Start reflecting activity
    3. start listing activity
    4. Quit");
    Console.Write("Select a choice from the menu: ");
    _option = Console.ReadLine();

    // Console.WriteLine($"Starting {_name}...");
    // Console.WriteLine(_description);
  }

  public virtual void Stop()
  {
    Console.WriteLine($"Stopping {_name}...");
  }

  public void ActivityDetail()
  {
    Console.WriteLine($"Welcome to the {_name}");
    Console.WriteLine("");
    Console.WriteLine($"{_description}");
    Console.WriteLine("");
  }

  public static void Animate(int seconds = 15)
  {
    int count = 0;
    while (count < seconds)
    {
      Console.Write("|");
      Thread.Sleep(500);
      Console.Write("\b \b"); // Erase the "|"

      Console.Write("/");
      Thread.Sleep(500);
      Console.Write("\b \b"); // Erase the "/"

      Console.Write("-");
      Thread.Sleep(500);
      Console.Write("\b \b"); // Erase the "-"

      Console.Write("\\");
      Thread.Sleep(500);
      Console.Write("\b \b"); // Erase the "\"

      count++;
    }
  }

  public void ActivityEnded(int seconds, int animationTime = 15)
  {
    Console.WriteLine("Well done!!");
    Console.WriteLine("");
    Animate(animationTime);
    Console.WriteLine("");
    Console.WriteLine($"You have complete {seconds} seconds of the {_name}");
    Thread.Sleep(2000);
  }



}