public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    public MathAssignment(string sName, string topic, string section, string problems):base(sName, topic)
    {
        _section = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_section}: Problems {_problems}";
    }
}