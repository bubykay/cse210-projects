using System;
using System.Collections.Generic;

abstract class Activity
{
  private DateTime _date;
  private int _minutes;

  public Activity(DateTime date, int minutes)
  {
    _date = date;
    _minutes = minutes;
  }

  public int GetMinutes() => _minutes;
  public DateTime GetDate() => _date;

  // Abstract methods (must be overridden in derived classes)
  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();

  public virtual string GetSummary()
  {
    return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min/km";
  }
}
