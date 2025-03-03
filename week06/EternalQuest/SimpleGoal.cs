using System;

public class SimpleGoal : Goal
{
  private bool isComplete;


  public SimpleGoal(string goalName, string goalDescription, int goalPoint) : base(goalName, goalDescription, goalPoint)
  {
    isComplete = false;

  }

  public override void RecordEvent()
  {
    isComplete = true;
  }

  public override bool IsComplete()
  {
    return isComplete;
  }

  public override string GetStringRepresentation()
  {
    return $"SimpleGoal|{_shortName}|{_goalDescription}|{_goalPoint}|{(IsComplete() ? "True" : "False")}";
  }


}