using System;
using System.Diagnostics;
using System.Threading;

class BreathingActivity : Activity
{
  public BreathingActivity()
      : base("Breathing", "This activity will help you relax and focus by working you through breathing in and out slowly. Clear your mind and focus on your breathing.")
  {
  }

  public void Run()
  {
    ActivityDetail();
    int seconds = Duration();
    GetReady();

    Console.WriteLine();

    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    Random random = new();

    while (stopwatch.Elapsed.TotalSeconds < seconds)
    {
      int breathIn = random.Next(seconds / 2);
      Console.WriteLine("");

      Console.Write("Breathe in...");
      CountDown(breathIn);
      Thread.Sleep(breathIn * 1000);

      Console.WriteLine("");

      int breatheOut = random.Next(seconds / 2);
      Console.Write("Breathe out... ");
      CountDown(breatheOut);
      Thread.Sleep(breatheOut * 1000);
    }

    stopwatch.Stop();
    ActivityEnded(seconds, 10);
  }
}
