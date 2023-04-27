using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        int lastdigit;
        string grade_opt;

        grade = 0;
        grade_opt = "";
        Console.Write("What is your grade precentage? ");
        grade = int.Parse(Console.ReadLine());
        lastdigit = (grade % 10);
        
        if (grade < 97 || grade > 60)
        {
            if (lastdigit >= 7)
            {
            grade_opt = "+";
            }
            else if (lastdigit < 3)
            {
            grade_opt = "-";
            }
        }
        

        if (grade >= 90)
        {
            Console.WriteLine($"You got an 'A{grade_opt}' ");
            Console.WriteLine("You Passed the Class");
            
        }
        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine($"You got an 'B{grade_opt}' ");
            Console.WriteLine("You Passed the Class");
        }
        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine($"You got an 'C{grade_opt}' ");
            Console.WriteLine("You Passed the Class");

        }
        else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine($"You got an 'D{grade_opt}' ");
            Console.WriteLine("You did not pass the class try to get your grade up to at least a 70% ");
        
        }
        else if (grade < 60)
        {
            Console.WriteLine("You got an 'F' ");
            Console.WriteLine("You did not pass the class try to get your grade up to at least a 70% ");
        }
        else
            Console.WriteLine("Invalid entry");
    }
}
