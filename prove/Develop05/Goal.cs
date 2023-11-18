public class Goal
{
    protected string _goalName;
    protected int userScore;
    protected string _newSimpleGoal;
    protected string _newChecklistGoal;
    protected string _newEternalGoal;
    protected List<Goal> goals;
    protected string fileName;
    public Goal(string goalName)
    {
        _goalName = goalName;
    }
    
    protected virtual string GetName()
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
    


    /*
    protected override int RecordEvent()
    {
        CompletionStatus = true;
        return points;
    }
    */
}