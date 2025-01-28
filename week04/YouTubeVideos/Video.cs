using System.Runtime.InteropServices;

public class Video(string title, string author, int length)
{
  private readonly string _title = title;
  private readonly string _author = author;
  private readonly int _length = length;
  private readonly List<Comment> _comments = [];

  public void AddComment(string name, string text)
  {
    _comments.Add(new Comment(name, text));
  }

  public void ShowComments()
  {
    if (_comments.Count == 0)
    {
      Console.WriteLine("No comments yet");
      return;
    }
    foreach (Comment comment in _comments)
    {
      Console.WriteLine(comment);
    }
  }

  public int NumberOfComment()
  {
    return this._comments.Count;
  }
  public string Title()
  {
    return _title;
  }
  public int Length()
  {
    return _length;
  }
  public string Author()
  {
    return _author;
  }


  public override string ToString()
  {
    return $"{_title} by {_author} {_length}mins:";
  }



}