class Swimming : Activity
{
    public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / (_lengthMinutes / 60.0));
    }

    public override double GetPace()
    {
        return _lengthMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        string distanceUnit = "km";
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{base.GetSummary()} - Distance: {distance} {distanceUnit}, Speed: {speed} kph, Pace: {pace} min/{distanceUnit}";
    }
}