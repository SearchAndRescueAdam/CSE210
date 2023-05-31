using System;

class Program
{
    static void Main(string[] args)
    {
        var john = new MathAssignment("John", "Subtration", "Section 7.3", "Problems 8-19");
        var john1 = new WritingAssignment("John", "English", "The Causes of World War II by Mary Waters");
        john.GetSummary();
        john.GetHomeworkList();
        john1.GetWritingInformation();

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
        Console.WriteLine($"{_textbookSelection}, {_problems}");
    }

}



class WritingAssignment: Assignment {
    private string _title;

    public WritingAssignment(string studentName, string topic, string title): base(studentName, topic){
        _title = title;
    }

    public void GetWritingInformation() {
        GetSummary();
        Console.WriteLine($"{_title}");
    }
}
