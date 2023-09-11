// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Text;

static void GetUserData()
{
    Console.Write("Enter name: ");
    string name = Console.ReadLine();
    Console.Write("Enter age: ");
    string age = Console.ReadLine();

    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Hello {0}, You are {1} years old", name, age);
    Console.ForegroundColor = prevColor;
}

static void FormatNumericalData()
{
    Console.WriteLine("99999 in various format: ");
    Console.WriteLine("c:  {0:c}", 99999);
    Console.WriteLine("d9: {0:d9}", 99999);
    Console.WriteLine("f3: {0:f3}", 99999);
    Console.WriteLine("n:  {0:n}", 99999);
    Console.WriteLine("E:  {0:E}", 99999);
    Console.WriteLine("e:  {0:e}", 99999);
    Console.WriteLine("X:  {0:X}", 99999);
    Console.WriteLine("x:  {0:x}", 99999);
    Console.WriteLine("g:  {0:g}", 99999);
}

static void ObjectFunctionality()
{
    Console.WriteLine("System.Object Functionality");
    Console.WriteLine(23.ToString());
    Console.WriteLine(23.GetHashCode());
    Console.WriteLine(23.Equals(22));
    Console.WriteLine(23.GetType());
}

static void ParseString()
{
    Console.WriteLine("Parse with TryParse: ");
    if (bool.TryParse("True", out bool b))
    {
        Console.WriteLine("Success: {0}", b); 
    } else
    {
        Console.WriteLine("Defaul: {0}", b);
    }
}

static void FunWithStringBuilder()
{
    StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
    sb.Append("\n");
    sb.AppendLine("Half Life " + "2");
    sb.Replace("2", "But Enjoy");
    Console.WriteLine(sb.ToString());
    Console.WriteLine(sb.Length);
}

static void LinqQueryOverInts()
{
    int[] numbers = new int[] { 10, 20, 30, 40, 1, 2, 3, 8 };
    var subset = from i in numbers where i < 10 select i;
    foreach (var i in subset)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine(subset.GetType().Name);
    Console.WriteLine(subset.GetType().Namespace);
}

static void ConditionalRefExample()
{
    var smallArray = new int[] { 1, 2, 3, 4, 5 };
    var largeArray = new int[] { 10, 20, 30, 40, 50 };
    int idx = 7;
    ref int refValue = ref ((idx < 5) ? ref smallArray[idx] : ref largeArray[idx - 5]);
    refValue = 0;
    idx = 2;
    ((idx < 5) ? ref smallArray[idx] : ref largeArray[idx]) = 100;
    Console.WriteLine(string.Join(" ", smallArray)); // 1 2 100 4 5
    Console.WriteLine(string.Join(" ", largeArray)); // 10 20 0 40 50
}

static void SwitchOnEnum()
{
    Console.Write("Enter your faorite day of week: ");
    DayOfWeek favDay;
    try
    {
        favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Bad Input!");
        return;
    }
    switch (favDay)
    {
        case DayOfWeek.Sunday:
        case DayOfWeek.Saturday:
            Console.WriteLine("Relax~");
            break;
        case DayOfWeek.Monday:
            Console.WriteLine("Is there anything worse?");
            goto case DayOfWeek.Tuesday;
        case DayOfWeek.Tuesday:
        case DayOfWeek.Wednesday:
            Console.WriteLine("At least it is not Monday");
            break;
        case DayOfWeek.Thursday:
            Console.WriteLine("Hangout with friends");
            break;
        case DayOfWeek.Friday:
            Console.WriteLine("Party all night!");
            break;
    }   
}

static void PartternMatchingSwitch()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Pick your language preference: ");
    object langChoice = Console.ReadLine();
    var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;
    switch (choice)
    {
        case int i when i == 2:
        case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        case int i when i == 1:
        case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("C#: Good choice, C# is a fine language");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;
    }
}

static string FromRainbow(string colorBand)
{
    return colorBand switch
    {
        "Red" => "#FF0000",
        "Orange" => "#FF7F00",
        "Yellow" => "#FFFF00",
        "Green" => "#00FF00",
        "Blue" => "#0000FF",
        "Indigo" => "#4B0082",
        "Violet" => "#9400D3",
        _ => "#FFFFFF",
    };
}

static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins.",
        ("rock", "scissors") => "Rock wins.",
        ("paper", "rock") => "Paper wins.",
        ("paper", "scissors") => "Scissors wins.",
        ("scissors", "rock") => "Rock wins.",
        ("scissors", "paper") => "Scissors wins.",
        (_, _) => "Tie.",
    };
}

static void RectArray()
{
    int[,] myMatrix;
    myMatrix = new int[3, 4];
    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 4; j++)
            myMatrix[i, j] = i * j;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
            Console.Write(myMatrix[i, j] + "\t");
        Console.WriteLine();
    }
}

static void JaggedArray()
{
    int[][] myJaggedArray = new int[5][];
    for (int i = 0; i < myJaggedArray.Length; i++)
        myJaggedArray[i] = new int[i + 7];
    for (int i = 0; i < myJaggedArray.Length; i++)
    {
        for (int j = 0; j < myJaggedArray[i].Length; j++)
            Console.Write(myJaggedArray[i][j] + " ");
        Console.WriteLine();
    }
}

enum EmpTypeEnum
{
    Manager,
    Grunt,
    Contractor,
    VicePresident
}

EmpTypeEnum = EmpType.Contractor;
AskForBonus(emp);
Console.ReadLine();

static void 