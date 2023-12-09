class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    //Create Lecture variable then add all the related attributes into it
    //And follow by :base(the five attributes) because Lecture class is a child class of the parent Event class
    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\n    Type: Lecture\n    Speaker: {_speaker}\n    Capacity: {_capacity}";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Lecture\n    Title: {_title}\n    Date: {_date.ToShortDateString()}";
    }
}