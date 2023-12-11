class Cycling : Activity
{
    public Cycling(DateTime date, int lengthMinutes, double speed) : base(date, lengthMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return GetSpeed() * (_lengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return 60.0 / GetSpeed();
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