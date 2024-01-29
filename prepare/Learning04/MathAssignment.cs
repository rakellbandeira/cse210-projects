using System;

public class MathAssignment: Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSect, string problems) : base (studentName, topic)
    {
        _textbookSection = textbookSect;
        _problems = problems;
        _studentName = studentName;
        _topic = topic;

    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems {_problems}";
    }


}