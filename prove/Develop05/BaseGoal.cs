public class BaseGoal
{
    public string _goalName;
    public BaseGoal(string goalName)
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