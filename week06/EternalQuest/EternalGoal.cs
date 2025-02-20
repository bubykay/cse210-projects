class EternalGoal : Goal
{
  public EternalGoal(string goalName, string goalDescription, int goalPoint)
      : base(goalName, goalDescription, goalPoint)
  {
  }

  public override string GetStringRepresentation()
  {
    return $"EternalGoal|{_shortName}|{_goalDescription}|{_goalPoint}";
  }

  public override bool IsComplete()
  {
    return false;
  }

  public override void RecordEvent()
  {

  }
}
