public class EternalGoal : Goal
{
    public EternalGoal(int points, string name, string description)
        : base(points, name, description)
    {

    }

    public override int RecordEvent()
    {
        return base.GetPoints();
    }

    public override bool CheckOff()
    {
        return false;
    }

    public override string GetFileLine()
    {
        string fileLine = $"EternalGoal:{base.GetName()},{base.GetDescription()},{base.GetPoints()}";

        return fileLine;
    }

    public override string DisplayGoal()
    {
        string goalDetails = $"{base.GetName()} ({base.GetDescription()})";

        return goalDetails;
    }
}