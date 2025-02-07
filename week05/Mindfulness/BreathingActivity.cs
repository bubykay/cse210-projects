using System.Diagnostics;

class BreathingActivity : Activity
{
  public BreathingActivity() : base("Breathing", "This activity will help you relax and focus by working you through breathing in and out slowly. Clear your mind and focus on your breathing.")
  {
  }
  public void Greetings()
  {

    ActivityDetail();
    Console.Write("How long in seconds would you like for your session ");
    int seconds = int.Parse(Console.ReadLine());
    int count = 0;
    Console.Clear();
    Console.WriteLine("Get ready...");
    Console.WriteLine("");
    Stopwatch stopwatch = new Stopwatch();

    int remainder = seconds % 3;

    while (count < seconds)
    {
      int splitTime = (seconds - remainder) / 3 * 1000;

      if (count >= seconds) break;
      Console.Write("Breathe in...");
      Console.WriteLine("");
      Thread.Sleep(splitTime / 2);
      count += splitTime / 2000;

      if (count >= seconds) break;
      Console.WriteLine("Breathe out...");
      Console.WriteLine("");
      Thread.Sleep(splitTime / 2);

      count += splitTime / 2000;

    }

    ActivityEnded(seconds, 10);

  }
}



