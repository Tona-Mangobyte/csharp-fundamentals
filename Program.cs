// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int num = 3;
Console.WriteLine(num);*/

using System;

namespace HelloWorld;

using PointTuple = (int X, int Y);

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

        double width = 3, height = 4;
        string info = $"Hypotenuse: {Math.Sqrt(width * width + height * height)}";
        Console.WriteLine(info);
        string info2 = string.Format("Hypotenuse: {0}",
            Math.Sqrt(width * width + height * height));
        Console.WriteLine(info2);


        /*string json = MakeRightAngledTriangleJson(width, height);
        Console.WriteLine(json);
        string json2 = MakeRightAngledTriangleJson2(width, height);
        Console.WriteLine(json2);*/


        // Tuples
        (int X, int Y) point = (10, 5);
        Console.WriteLine($"X: {point.X}, Y: {point.Y}");

        PointTuple center = (20, 10);
        Console.WriteLine($"X: {center.X}, Y: {center.Y}");

        var point3 = (X: 10, Y: 5);
        Console.WriteLine($"X: {point3.X}, Y: {point3.Y}");

        (int, int) point4 = (10, 5);
        Console.WriteLine($"X: {point4.Item1}, Y: {point4.Item2}");

        foreach (int number in numbers1)
        {
            Console.WriteLine(number);
        }

        var counter = new Counter();
        Console.WriteLine(counter.GetNextValue());
        Console.WriteLine(counter.GetNextValue());

        var counter2 = new CounterWithPrimaryConstructor(10);
        Console.WriteLine(counter2.GetNextValue()); 
        Console.WriteLine(counter2.GetNextValue());

        var counter3 = new CounterWithTotal();
        Console.WriteLine(counter3.GetNextValue());
        Console.WriteLine(counter3.GetNextValue());
        Console.WriteLine(CounterWithTotal.TotalCount);

        var person = new Person();
        // person.Name = "Tona";
        person.FavoriteColor = "Black";
        Console.WriteLine(person.Name);
        Console.WriteLine(person.FavoriteColor);

        var person2 = new PersonInitializationConstructor("Tona", null);
        Console.WriteLine(person2.Name);
        Console.WriteLine(person2.FavoriteColor);

        var person3 = new PersonPrimaryConstructor("Tona", "Black");
        Console.WriteLine(person3.Name);
        Console.WriteLine(person3.FavoriteColor);

        var person4 = new PersonModifiableProperties("Tona", "Black");
        Console.WriteLine(person4.Name);
        Console.WriteLine(person4.FavoriteColor);
        
    }


    static string MakeRightAngledTriangleJson(double width, double height)
    {
        // Wonky indentation is necessary here to get correctly indented output
        return @$"{{
        ""width"": {width},
        ""height"": {height},
        ""calculated"": {{
            ""hypotenuse"": {Math.Sqrt(width * width + height * height)},
            ""area"": {width * height / 2}
        }}
    }}";
    }
    static string MakeRightAngledTriangleJson2(double width, double height)
    {
        return $$"""
            {
                "width": {{width}},
                "height": {{height}},
                "calculated": {
                    "hypotenuse": {{Math.Sqrt(width * width + height * height)}},
                    "area": {{width * height / 2}}
                }
            }
            """;
    }
}