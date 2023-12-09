class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected string _time;
    protected Address _address;

    //Create Event variable then add all the related attributes into it
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    //Create GenerateStandardDetail method then assign neccessary attributes and  then return the result to the method
    //Create indent by using spaces to make the display neat
    public virtual string GenerateStandardDetails()
    {
        return $"Title: {_title}\n    Description: {_description}\n    Date: {_date.ToShortDateString()}\n    Time: {_time}\n    Address: {_address.GetFullAddress()}";
    }

    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    public virtual string GenerateShortDescription()
    {
        return $"Type: Generic Event\n    Title: {_title}\n    Date: {_date.ToShortDateString()}";
    }
}