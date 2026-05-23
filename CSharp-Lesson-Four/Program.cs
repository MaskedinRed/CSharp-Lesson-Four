// See https://aka.ms/new-console-template for more information

namespace CSharp_Lesson_Four;

class Program
{
    static void SayHello()
    {
        Console.WriteLine("Hello from my function!");
    }

    static void Main(string[] args)
    {
        SayHello();
        SayHello();
        SayHello();
    }
}

static void GreetPerson(string name, int age)
{
    Console.WriteLine($"Hello, {name}! Your are {age} years old as of now.");
}

static void Main(string[] args)
{
    GreetPerson("Toyo Saito", 13);
    GreetPerson("Hana Cheng", 16);
    GreetPerson("Izumi Saito", 18);
}

namespace CSharp_Lesson_Four;

class Program
{
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static double CalculateCircleArea(double radius)
    {
        return 3.14159 * radius * radius;
    }

    static void Main(string[] args)
    {
        int sum = AddNumbers(5, 3);
        Console.WriteLine($"5 + 3 = {sum}");

        double area = CalculateCircleArea(4.0);
        Console.WriteLine($"Circle area : {area}");
    }
}

namespace CSharp_Lesson_Four;

class Program
{
    static double Add(double x, double y) => x + y;
    static double Subtract(double x, double y) => x - y;
    static double Multiply(double x, double y) => x * y;
    static double Divide(double x, double y) => x / y;

    static void DisplayMenu()
    {
        Console.WriteLine("=== Calculator ===");
        Console.WriteLine("1. Add  2. Subtract  3. Multiply  4. Divide");
    }

    static double GetValidNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }

            Console.WriteLine("That's not even a number... -_-");
        }
    }
    static void Main(string[] args)
    {
        DisplayMenu();
        Console.WriteLine("Choose your operation (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        double num1 = GetValidNumber("First Number: ");
        double num2 = GetValidNumber("Second Number: ");

        double result = choice switch
        {
            1 => Add(num1, num2),
            2 => Subtract(num1, num2),
            3 => Multiply(num1, num2),
            4 => Divide(num1, num2),
            _ => 0
        };

        Console.WriteLine($"Result: {result}");
    }
}

static int GenerateRandomNumber(int min, int max)
{
    Random random = new Random();
    return random.Next(min, max + 1);
}

static bool AskMathQuestion()
{
    int a = GenerateRandomNumber(1, 10);
    int b = GenerateRandomNumber(1, 10);
    int correct = a + b;
    
    Console.Write($"What is {a} + {b}? ");
    int answer = int.Parse(Console.ReadLine());

    return answer == correct;
}
