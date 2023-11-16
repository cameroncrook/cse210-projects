public class ChecklistGoal : Goal
{
    private int _completeTotal;
    private int _completeCounter;
    private int _bonusPoints;

    public ChecklistGoal(int completeTotal, int completeCounter, int bonusPoints, int points, string name, string description)
        : base(points, name, description)
    {
        _completeTotal = completeTotal;
        _completeCounter = completeCounter;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _completeCounter += 1;

        int points = base.GetPoints();

        if (CheckOff()) {
            points += _bonusPoints;
        }

        return points;
    }

    public override bool CheckOff()
    {
        if (_completeCounter >= _completeTotal)
        {
            return true;
        } else 
        {
            return false;
        }
    }

    public override string GetFileLine()
    {
        string fileLine = $"ChecklistGoal:{base.GetName()},{base.GetDescription()},{base.GetPoints()},{_bonusPoints},{_completeTotal},{_completeCounter}";

        return fileLine;
    }

    public override string DisplayGoal()
    {
        string goalDetails = $"{base.GetName()} ({base.GetDescription()}) -- Currently completed: {_completeCounter}/{_completeTotal}";

        return goalDetails;
    }
}