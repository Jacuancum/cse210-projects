class OutdoorGathering : Event
{
    private string _weatherForecast;

    //Create OutdoorGathering variable then add all the related attributes into it
    //And follow by :base(the five attributes) because OutdoorGathering class is a child class of the parent Event class
    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\n    Type: Outdoor Gathering\n    Weather Forecast: {_weatherForecast}";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Outdoor Gathering\n    Title: {_title}\n    Date: {_date.ToShortDateString()}";
    }
}