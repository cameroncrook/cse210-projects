public abstract class Goal
{
    private int _points;
    private string _name;
    private string _description;

    public Goal (int points, string name, string description)
    {
        _points = points;
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract int RecordEvent();

    public abstract bool CheckOff();

    public abstract string GetFileLine();

    public abstract string DisplayGoal();
}