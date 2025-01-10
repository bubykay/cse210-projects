using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
public class Journal
{
  public string _another;
  public string _filePath;
  public int _option;
  private Entry entry = new();



  public void JournalMenu()
  {
    Console.Write(@"Please select one of the following choices
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do?  ");
  }

  public void SaveJournal()
  {
    Console.WriteLine("What is the filename");
    string _filePath = Console.ReadLine();
    entry.SaveEntry(_filePath);
  }

  public void LoadJournal()
  {
    Console.WriteLine("What is the filename");
    string _filePath = Console.ReadLine();
    entry.LoadEntries(_filePath);

  }

  public void WriteToJournal(string prompt)
  {
    Console.WriteLine(prompt);
    Console.Write("> ");
    string _journal = Console.ReadLine();
    entry.NewEntry(_journal, prompt);
  }

  public void DisplayJournal()
  {
    entry.DisplayEnteries();
  }

}