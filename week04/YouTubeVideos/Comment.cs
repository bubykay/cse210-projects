class Comment
{
  private readonly string _name;
  private readonly string _text;
  public Comment(string name, string text)
  {
    _name = name;
    _text = text;

  }
  public override string ToString()
  {
    return $"{_name}:  {_text}";
  }
}