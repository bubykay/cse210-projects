class Swimming : Activity
{
  private int _laps;
  private const double LapDistanceKm = 50.0 / 1000.0; // 50 meters per lap converted to km

  public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
  {
    _laps = laps;
  }

  public override double GetDistance() => _laps * LapDistanceKm;

  public override double GetSpeed() => GetDistance() / GetMinutes() * 60;

  public override double GetPace() => GetMinutes() / GetDistance();
}
