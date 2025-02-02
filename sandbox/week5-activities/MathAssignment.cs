
using System;

class MathAssignment
{
  private string _textBookSection = "";
  private string _problem = "";

  public string GetHomeWorkList()
  {
    return $"{_textBookSection} {_problem}";
  }
}