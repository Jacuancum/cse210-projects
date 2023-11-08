public class Goal
{
    public string _goalName;
    public int _score;
    public Goal(string goalName)
    {
        _goalName = goalName;
    }

    public string GetName()
    {
        return _goalName;
    }

    public void SetName(string goalName)
    {
        _goalName = goalName;
    }
}