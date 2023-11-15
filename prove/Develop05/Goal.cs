public class Goal
{
    public string _goalName;
    public string _goalDescription;
    public string _point;
    public int _userScore;
    public string newSimpleGoal;
    public string newChecklistGoal;
    public string newEternalGoal;
    public int lineNumber;
    public string fileName;
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