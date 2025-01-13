using System.Text;
using System;

public class Entry
{

  private DateTime dateTime = DateTime.Now;
  private List<string> journalEntries = [];


  public void NewEntry(string journal, string prompt)
  {
    string now = dateTime.ToString("dd:MM:yyyy HH:mm");
    journalEntries.Add($"{now} - prompt: {prompt}\n{journal}");

  }

  public void DisplayEnteries()
  {
    foreach (string journal in journalEntries)
    {
      Console.WriteLine(journal + "\n");
    }
  }
  public void LoadEntries(string _filePath)
  {
    try
    {

      if (!File.Exists(_filePath))
      {
        Console.WriteLine($"{_filePath} does not exist");
        return;
      }
      using StreamReader _streamReader = new(_filePath, Encoding.UTF8);
      _streamReader.BaseStream.Position = 0;
      string line;
      while ((line = _streamReader.ReadLine()) != null)
      {
        journalEntries.Add(line);
      }
    }
    catch (Exception e)
    {
      Console.WriteLine($"An error occurred: {e.Message}"); ;
    }
  }

  public void SaveEntry(string _filePath)
  {
    try
    {

      using StreamWriter _streamWriter = new(_filePath, true, Encoding.UTF8);
      foreach (string journal in journalEntries)
        _streamWriter.WriteLine(journal);
      Console.WriteLine("Journal successfully written");
    }
    catch (Exception e)
    {
      Console.WriteLine($"An error occurred: {e.Message}"); ; ;
    }

  }
}