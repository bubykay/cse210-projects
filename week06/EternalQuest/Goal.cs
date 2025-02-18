public abstract class Goal
{
  protected string _shortName;
  protected string _goalDescription;
  protected int _goalPoint;

  public Goal(string goalName, string goalDescription, int goalPoint)
  {
    _shortName = goalName;
    _goalDescription = goalDescription;
    _goalPoint = goalPoint;
  }

  // checkbox
  // shortname
  // description
  public abstract void RecordEvent();
  public abstract bool IsComplete();
  public abstract string GetStringRepresentation();

  public string GetDetailsString()
  {
    // Implementation for GetDetailsString
    return $"[] {_shortName} ({_goalDescription})";
  }

  public string GetGoalName()
  {

    return _shortName;
  }
  public string GetGoalDescription()
  {
    return _goalDescription;
  }
}