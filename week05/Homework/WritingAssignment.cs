class WritingAssignment : Assignment
{
  public string _title;

  public string GetWritingInformation()
  {
    return $"Title: {_title}";
  }
}