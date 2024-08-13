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
        

        // Struct
        var point5 = new PointStruct(10, 5);
        Console.WriteLine($"X: {point5.X}, Y: {point5.Y}");
        Console.WriteLine(point5.DistanceFromOrigin());

        var point6 = new PointStructComparison(10, 5);
        Console.WriteLine($"X: {point6.X}, Y: {point6.Y}");
        Console.WriteLine(point6.DistanceFromOrigin());

        var point7 = new PointStructComparison(10, 5);
        // custom comparison
        Console.WriteLine(point6 == point7);
        Console.WriteLine(point6 != point7);
        Console.WriteLine(point6.Equals(point7));
        Console.WriteLine(point6.GetHashCode());
        Console.WriteLine(point7.GetHashCode());

        // Record Struct
        var point8 = new PointRecord(10, 5);
        Console.WriteLine($"X: {point8.X}, Y: {point8.Y}");
        var point9 = new PointStructRecord(10, 5);
        Console.WriteLine($"X: {point9.X}, Y: {point9.Y}");
        var point10 = new PointReadonlyStructRecord(10, 5);
        Console.WriteLine($"X: {point10.X}, Y: {point10.Y}");


        // class with a primary constructor and no other constructors
        var item = new Item(30, "ABC Can");
        Console.WriteLine(item);

        var item2 = new ItemPrimaryConstructor(30, "ABC Can");
        Console.WriteLine(item2);

        // Record type with customized copy constructor
        var itemRecord = new ItemRecord(30, "ABC Can");
        Console.WriteLine(itemRecord);

        // Multi constructor
        var item3 = new ItemMultiConstructor();
        Console.WriteLine(item3);
        var item4 = new ItemMultiConstructor(30);
        Console.WriteLine(item4);
        var item5 = new ItemMultiConstructor(30, "ABC Can");
        Console.WriteLine(item5);


        // Passing arguments by reference
        int result = Divide(10, 3, out int remainder);
        Console.WriteLine($"Result: {result}, Remainder: {remainder}");
        int r, q;
        q = Divide(10, 3, out r);
        Console.WriteLine($"3: {q}, {r}");
        q = Divide(10, 4, out r);
        Console.WriteLine($"4: {q}, {r}");
        q = Divide(10, 3, out _);
        Console.WriteLine($"5: {q}");

        // Calling a method with a ref argument
        long x = 41;
        Interlocked.Increment(ref x);
        Console.WriteLine(x);

        // Calling a method with an in parameter
        var rect = new Rect(10, 20, 100, 100);
        double area = GetArea(in rect);
        double area2 = GetArea(rect);
        Console.WriteLine(area);
        Console.WriteLine(area2);

        // local ref variable
        string? rose = null;
        ref string? rosaIndica = ref rose;
        rosaIndica = "smell as sweet";
        Console.WriteLine($"A rose by any other name would {rose}");
        
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

    // Passing arguments by reference
    public static int Divide(int x, int y, out int remainder)
    {
        remainder = x % y;
        return x / y;
    }


    public readonly record struct Rect(double X, double Y, double Width, double Height);
    // method with an in parameter
    public static double GetArea(in Rect r) => r.Width * r.Height;
}