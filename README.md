# 🎯 C# Functions & Code Organization Project

## Lesson Snapshot
Transform messy code into clean, reusable functions that work like building blocks! (Ages 8-18)

## Folder & File Map
```
FunctionsAndOrganization/
├── .git/
├── .gitignore
├── FunctionsAndOrganization.csproj
└── Program.cs
```

## Step-by-Step Build Guide

### 1. Fork and Clone the Repository ✅
- **What to do**: Go to [https://github.com/PhillyCoderDojo/CSharp-Lesson-Four](https://github.com/PhillyCoderDojo/session4-functions) → Click "Fork" → Open GitHub Desktop → Clone your fork
- **File(s) touched**: Creating project folder
- **Code snippet**: None
- **Why it matters**: Get your own workspace for function practice
- **Git command**: `git clone https://github.com/YOUR-USERNAME/CSharp-Lesson-Four.git`

### 2. Open Project in Rider ✅
- **What to do**: Open Rider → File → Open → Select your cloned folder → Click OK
- **File(s) touched**: Loading project
- **Code snippet**: None
- **Why it matters**: Time to organize code like a pro!
- **Git command**: None

### 3. Create Your First Function 📦
- **What to do**: Open Program.cs and create a simple greeting function
- **File(s) touched**: Program.cs
- **Code snippet**:
```csharp
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
```
- **Why it matters**: Functions let you reuse code instead of copying
- **Git command**: `git add . && git commit -m "Create first function without parameters"`

### 4. Add Parameters to Functions 🎛️
- **What to do**: Make your function accept input values
- **File(s) touched**: Program.cs
- **Code snippet**:
```csharp
static void GreetPerson(string name, int age)
{
    Console.WriteLine($"Hello {name}! You are {age} years old.");
}

static void Main(string[] args)
{
    GreetPerson("Alex", 12);
    GreetPerson("Jordan", 15);
    GreetPerson("Casey", 10);
}
```
- **Why it matters**: Parameters make functions flexible with different inputs
- **Git command**: `git add . && git commit -m "Add parameters to function"`

### 5. Create Functions That Return Values 🔄
- **What to do**: Build functions that calculate and give back results
- **File(s) touched**: Program.cs
- **Code snippet**:
```csharp
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
    Console.WriteLine($"Circle area: {area}");
}
```
- **Why it matters**: Return values let functions send results back
- **Git command**: `git add . && git commit -m "Add functions with return values"`

### 6. Build a Calculator with Functions 🧮
- **What to do**: Create separate functions for each math operation
- **File(s) touched**: Program.cs (replace existing code)
- **Code snippet**:
```csharp
static double Add(double x, double y) => x + y;
static double Subtract(double x, double y) => x - y;
static double Multiply(double x, double y) => x * y;
static double Divide(double x, double y) => x / y;

static void DisplayMenu()
{
    Console.WriteLine("=== Calculator ===");
    Console.WriteLine("1. Add  2. Subtract  3. Multiply  4. Divide");
}

static double GetNumber(string prompt)
{
    Console.Write(prompt);
    return double.Parse(Console.ReadLine());
}

static void Main(string[] args)
{
    DisplayMenu();
    Console.Write("Choose operation (1-4): ");
    int choice = int.Parse(Console.ReadLine());
    
    double num1 = GetNumber("First number: ");
    double num2 = GetNumber("Second number: ");
    
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
```
- **Why it matters**: Each function has one clear job
- **Git command**: `git add . && git commit -m "Create organized calculator with functions"`

### 7. Add Input Validation Function 🛡️
- **What to do**: Create a safe number input function
- **File(s) touched**: Program.cs (add this function)
- **Code snippet**:
```csharp
static double GetValidNumber(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        if (double.TryParse(Console.ReadLine(), out double result))
        {
            return result;
        }
        Console.WriteLine("❌ Please enter a valid number!");
    }
}
```
- **Why it matters**: Functions can handle errors gracefully
- **Git command**: `git add . && git commit -m "Add input validation function"`

### 8. Push Your Organized Code 🚀
- **What to do**: In GitHub Desktop → Commit changes → Push origin
- **File(s) touched**: Uploading to GitHub
- **Code snippet**: None
- **Why it matters**: Share your well-organized functions
- **Git command**: `git push origin main`

## Run & Test ▶️
- Press Ctrl+F5 or click green ▶️ button in Rider
- **Expected output**: Calculator menu, prompts for numbers, shows calculation results
- **Common error**: "Method must have a return type" - forgot `static` or return type
- **Fix**: Make sure all functions start with `static` and specify return type

## Bonus Challenge 🔥
Create a "Math Quiz Game" using functions!

**Hint**:
```csharp
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
```
