class Scripture
{
  private readonly Reference _reference;
  private readonly List<Word> _words;

  public Scripture(Reference reference, string text)
  {
    string[] words = text.Split(' ');
    _words = [];
    foreach (string item in words)
    {
      _words.Add(new Word(item));
    }
    _reference = reference;
  }

  public void HideRandomWord(int numberToHide)
  {
    Random random = new();
    for (int i = 0; i < numberToHide; i++)
    {
      if (IsCompletelyHidden())
      {
        break;
      }
      int randomIndex = random.Next(_words.Count);
      while (true)
      {
        if (!_words[randomIndex].IsHidden())
        {
          break;
        }
        randomIndex = random.Next(_words.Count);
      }
      _words[randomIndex].Hide();

    }
  }

  public void GetDisplayText()
  {
    Console.Write(_reference.GetDisplayString() + " "); ;
    foreach (Word word in _words)
    {
      Console.Write(word.GetDisplay() + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Press enter to continue or type \"quit\" to finish");
  }
  public bool IsCompletelyHidden()
  {
    return _words.All(word => word.IsHidden());
  }
}