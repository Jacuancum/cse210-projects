public class Goal
{
    protected string _goalName;
    protected int _userScore;
    protected string _newSimpleGoal;
    protected string _newChecklistGoal;
    protected string _newEternalGoal;
    protected string _result;
    protected List<Goal> goals;
    protected string _fileName;
    public Goal(string goalName)
    {
        _goalName = goalName;
    }
    
    public virtual string GetName()
    {
        return _goalName;
    }

    public virtual void SetName(string goalName)
    {
        _goalName = goalName;
    }

    public virtual string GetNewGoal()
    {
        return _newSimpleGoal;
    }
    
}