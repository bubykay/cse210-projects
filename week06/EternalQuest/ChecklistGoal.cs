class ChecklistGoal : Goal
{
  private int _targetCount;
  private int _completedCount;
  private int _bonusPoints;

  public ChecklistGoal(string goalName, string goalDescription, int goalPoint, int targetCount, int bonusPoints)
      : base(goalName, goalDescription, goalPoint)
  {
    _targetCount = targetCount;
    _completedCount = 0;
    _bonusPoints = bonusPoints;
  }

  public override string GetStringRepresentation()
  {
    return $"ChecklistGoal|{_shortName}|{_goalDescription}|{_goalPoint}|{_bonusPoints}|{_targetCount}|{_completedCount}";
  }

  public override bool IsComplete()
  {
    return _completedCount >= _targetCount;
  }

  public override string GetDetailsString()
  {
    return $"{base.GetDetailsString()}, -- Currently completed {_completedCount}/{_targetCount}";
  }

  public override void RecordEvent()
  {
    if (!IsComplete())
    {
      _completedCount++; // Increase progress first

      if (IsComplete()) // If completed now, add bonus
      {
        _goalPoint += _bonusPoints;
      }
    }
  }
}
