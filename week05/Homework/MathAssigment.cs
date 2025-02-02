class MathAssigment : Assignment
{
  public string _textBookSection;
  public string _problem;

  public string GetHomeWorkList()
  {
    return $"Text Book Section: {_textBookSection}, Problem: {_problem}";
  }
}
