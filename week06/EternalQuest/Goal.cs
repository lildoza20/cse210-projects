using System;
using System.Security.Cryptography.X509Certificates;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string GetShortName()
    {
        return _shortName;
    }
    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }
    public virtual string GetStringRepresentation()
    {
        return $"Goal:{_shortName},{_description},{_points}";
    }
    public virtual int RecordEvent()
    {
        return 0;
    }
    public virtual bool IsComplete()
    {
        return false;
    }
}