class Assignment
{
  private string _stendentName = "John Doe";
  private string _topic = "Some Topic";

  public string GetSummary()
  {
    return $"Student: {_stendentName}, Topic: {_topic}";
  }
}
