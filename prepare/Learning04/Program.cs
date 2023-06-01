using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        a1.GetSummary();
        a2.GetHomeworkList();
        a3.GetWritingInformation();

    }
}

class Assignment {
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentName, string topic) {
        _studentName = studentName;
        _topic = topic;
    }
    public void GetSummary() {
        Console.WriteLine($"{_studentName} - {_topic}");

    }
}



class MathAssignment: Assignment {
    private string _textbookSelection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSelection, string problems): base(studentName, topic){
        _textbookSelection = textbookSelection;
        _problems = problems;
    }

    public void GetHomeworkList() {
        GetSummary();
        Console.WriteLine($"{_textbookSelection}, {_problems}\n");
    }

}



class WritingAssignment: Assignment {
    private string _title;

    public WritingAssignment(string studentName, string topic, string title): base(studentName, topic){
        _title = title;
    }

    public void GetWritingInformation() {
        GetSummary();
        Console.WriteLine($"{_title}\n");
    }
}
