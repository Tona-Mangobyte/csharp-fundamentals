// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int num = 3;
Console.WriteLine(num);*/

using System;

namespace HelloWorld;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<int> numbers1 = new List<int>();
        var numbers2 = new List<int>();
        List<int> numbers3 = new();
    
        numbers1.Add(1);
        numbers1.ForEach(Console.WriteLine);

// Declare and initialize a variable
        string part1 = "the ultimate question";
        string part2 = "of something";
        int theAnswer = 42;

        part2 = "of life, the universe, and everything";

        string questionText = "What is the answer to " + part1 + ", " + part2 + "?";
        string answerText = "The answer to " + part1 + ", " +
                            part2 + ", is: " + theAnswer;

        Console.WriteLine(questionText);
        Console.WriteLine(answerText);


// Multiple variables in a single declaration
        double a, b = 2.5, c = -3;
        a = 1.5;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}