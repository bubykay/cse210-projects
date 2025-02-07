class ListingActivity : Activity
{
  public ListingActivity() : base("name", "description")
  {
  }

  public void Greetings()
  {
    Console.WriteLine("Welcome to Listing Activities");
    Thread.Sleep(2000);
  }
}