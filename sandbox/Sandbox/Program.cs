using System;

class Program
{
    static void Main(string[] args)
    {
        var layne = new Person("Layne", "Moseley");
        var david = new Person("David", "Hasselhoff");

        layne.Talk();
        david.Talk();

    }
}

// Classification

class Person {

    //attributes
    //properties
    string firstName;
    string lastName;

    //constructor
    public Person(string fn,string ln) {
        firstName = fn;
        lastName = ln;

    }


    //behaviors
    //method

    public void Breathe() {
        Console.WriteLine("Breathing");
    }

    public void Walk() {
        Console.WriteLine("Walking");
    }

    public void Talk() {
        Console.WriteLine($"Hi! My name is {FullName()}");
    }

    public string FullName() {
        string full = String.Concat(firstName,  lastName);
        return full;
    }





public int GetTop() {
    return _top;
 }

 public void SetBottom(int newBottom) {

    

 }
}
 








