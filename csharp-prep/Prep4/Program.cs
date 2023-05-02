using System;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();
        int sum = 0;

        while (true) {

            Console.Write("Please enter a number (enter 0 to stop): ");

            int number = int.Parse(Console.ReadLine());

            if (number == 0) {
                break;
            }

            numbers.Add(number);
        }
        foreach (var num in numbers) {
            sum += num;
        
        }
        float average = (float)sum / (float)numbers.Count();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The sum is: {average}");
        Console.WriteLine($"The largest is: ");
    }
}
