using System.Security.Cryptography.X509Certificates;

class ReflectingActivity : Activity
{
  public ReflectingActivity() : base("name", "description")
  {
  }
  public void Greetings()
  {
    Console.WriteLine("Welcome to Relecting Activity");
    Thread.Sleep(2000);
  }
}