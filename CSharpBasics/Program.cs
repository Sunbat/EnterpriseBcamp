// ============================================================
// C# BASICS - EnterpriseBcamp
// A guided tour of core C# concepts
// ============================================================

// ---- 1. VARIABLES & DATA TYPES ----
Console.WriteLine("=== Variables & Data Types ===");

int age = 25;
double price = 9.99;
bool isLearning = true;
char grade = 'A';
string name = "Bootcamper";

Console.WriteLine($"Name: {name}, Age: {age}, Price: {price}, Grade: {grade}, Learning: {isLearning}");

// ---- 2. STRING INTERPOLATION & FORMATTING ----
Console.WriteLine("\n=== String Interpolation ===");

string fullGreeting = $"Hello, {name}! You are {age} years old.";
Console.WriteLine(fullGreeting);
Console.WriteLine($"Price formatted: {price:C}");   // Currency format
Console.WriteLine($"Pi to 3 decimals: {Math.PI:F3}");

// ---- 3. CONDITIONALS ----
Console.WriteLine("\n=== Conditionals ===");

int score = 78;
string letterGrade;

if (score >= 90)
    letterGrade = "A";
else if (score >= 80)
    letterGrade = "B";
else if (score >= 70)
    letterGrade = "C";
else
    letterGrade = "F";

Console.WriteLine($"Score {score} = Grade {letterGrade}");

// Switch expression (modern C# syntax)
string dayType = DateTime.Now.DayOfWeek switch
{
    DayOfWeek.Saturday or DayOfWeek.Sunday => "Weekend",
    _ => "Weekday"
};
Console.WriteLine($"Today ({DateTime.Now.DayOfWeek}) is a {dayType}");

// ---- 4. LOOPS ----
Console.WriteLine("\n=== Loops ===");

// for loop
Console.Write("For loop (1-5): ");
for (int i = 1; i <= 5; i++)
    Console.Write($"{i} ");
Console.WriteLine();

// while loop
Console.Write("While loop (countdown): ");
int countdown = 5;
while (countdown > 0)
{
    Console.Write($"{countdown} ");
    countdown--;
}
Console.WriteLine("Go!");

// foreach loop
string[] languages = { "C#", "SQL", "JavaScript", "Python" };
Console.Write("foreach loop: ");
foreach (string lang in languages)
    Console.Write($"{lang} ");
Console.WriteLine();

// ---- 5. ARRAYS & COLLECTIONS ----
Console.WriteLine("\n=== Arrays & Collections ===");

// Array
int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6 };
Array.Sort(numbers);
Console.WriteLine($"Sorted array: {string.Join(", ", numbers)}");

// List (dynamic size)
List<string> skills = new List<string> { "C#", "SQL" };
skills.Add("Entity Framework");
skills.Remove("SQL");
skills.Insert(1, "MS-SQL");
Console.WriteLine($"Skills list: {string.Join(", ", skills)}");

// Dictionary (key-value pairs)
Dictionary<string, int> scores = new()
{
    { "Alice", 95 },
    { "Bob", 82 },
    { "Carol", 91 }
};

foreach (var entry in scores)
    Console.WriteLine($"  {entry.Key}: {entry.Value}");

// ---- 6. METHODS ----
Console.WriteLine("\n=== Methods ===");

Console.WriteLine($"Sum(3, 4) = {Sum(3, 4)}");
Console.WriteLine($"IsEven(7) = {IsEven(7)}");
Console.WriteLine($"Greet(\"World\") = {Greet("World")}");

// ---- 7. CLASSES & OBJECTS ----
Console.WriteLine("\n=== Classes & Objects ===");

var person1 = new Person("Alice", 30);
var person2 = new Person("Bob", 25);

person1.Introduce();
person2.Introduce();
Console.WriteLine($"Older: {Person.OlderPerson(person1, person2).Name}");

Console.WriteLine("\nDone! You've covered the C# basics.");

// ============================================================
// METHOD DEFINITIONS
// ============================================================

static int Sum(int a, int b) => a + b;

static bool IsEven(int n) => n % 2 == 0;

static string Greet(string who) => $"Hello, {who}!";

// ============================================================
// CLASS DEFINITIONS
// ============================================================

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
    }

    public static Person OlderPerson(Person a, Person b) => a.Age >= b.Age ? a : b;
}
