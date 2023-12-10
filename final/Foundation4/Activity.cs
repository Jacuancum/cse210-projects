class Activity
{
    protected DateTime _date;
    protected int _lengthMinutes;
    protected double _distance;
    protected double _speed;
    protected int _laps;

    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} - {GetType().Name} ({_lengthMinutes} min)";
    }
}