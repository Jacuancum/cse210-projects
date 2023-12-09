class Reception : Event
{
    private string _rsvpEmail;

    //Create Reception variable then add all the related attributes into it
    //And follow by :base(the five attributes) because Reception class is a child class of the parent Event class
    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\n    Type: Reception\n    RSVP Email: {_rsvpEmail}";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Reception\n    Title: {_title}\n    Date: {_date.ToShortDateString()}";
    }
}
