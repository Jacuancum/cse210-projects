class Running : Activity
{
    public Running(DateTime date, int lengthMinutes, double distance) : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_lengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return _lengthMinutes / _distance;
    }

    public override string GetSummary()
    {
        string distanceUnit = "mile";
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        
        return $"{base.GetSummary()} - Distance: {distance} {distanceUnit}, Speed: {speed} mph, Pace: {pace} min/{distanceUnit}";
    }
}