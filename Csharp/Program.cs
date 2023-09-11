// See https://aka.ms/new-console-template for more information

using SuperBank;
using System.Collections.Generic;
using System.Text;

class Program
{
    /*
     * Testing SuperBank class
     */
    static void Main(string[] args)
    {
        var account = new BankAccount("Cheryl", 10000);
        Console.WriteLine(account.Balance);
        account.MakeWithdrawal(700, DateTime.Now, "Rental fees");
        account.MakeWithdrawal(15, DateTime.Now, "Pizza");
        account.MakeDeposit(120, DateTime.Now, "Shipping Stuff");
        try
        {
            var invalidAccount = new BankAccount("Thief", -5000);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Exception caught creating account with negatve balance");
            Console.WriteLine(e.Message);
        }
        Console.WriteLine(account.GetTransactionHistory());
    }
}

//static void getuserdata()
//{
//    console.write("enter name: ");
//    string name = console.readline();
//    console.write("enter age: ");
//    string age = console.readline();

//    consolecolor prevcolor = console.foregroundcolor;
//    console.foregroundcolor = consolecolor.yellow;
//    console.writeline("hello {0}, you are {1} years old", name, age);
//    console.foregroundcolor = prevcolor;
//}

//static void formatnumericaldata()
//{
//    console.writeline("99999 in various format: ");
//    console.writeline("c:  {0:c}", 99999);
//    console.writeline("d9: {0:d9}", 99999);
//    console.writeline("f3: {0:f3}", 99999);
//    console.writeline("n:  {0:n}", 99999);
//    console.writeline("e:  {0:e}", 99999);
//    console.writeline("e:  {0:e}", 99999);
//    console.writeline("x:  {0:x}", 99999);
//    console.writeline("x:  {0:x}", 99999);
//    console.writeline("g:  {0:g}", 99999);
//}

//static void objectfunctionality()
//{
//    console.writeline("system.object functionality");
//    console.writeline(23.tostring());
//    console.writeline(23.gethashcode());
//    console.writeline(23.equals(22));
//    console.writeline(23.gettype());
//}

//static void parsestring()
//{
//    console.writeline("parse with tryparse: ");
//    if (bool.tryparse("true", out bool b))
//    {
//        console.writeline("success: {0}", b);
//    }
//    else
//    {
//        console.writeline("defaul: {0}", b);
//    }
//}

//static void funwithstringbuilder()
//{
//    stringbuilder sb = new stringbuilder("**** fantastic games ****");
//    sb.append("\n");
//    sb.appendline("half life " + "2");
//    sb.replace("2", "but enjoy");
//    console.writeline(sb.tostring());
//    console.writeline(sb.length);
//}

//static void linqqueryoverints()
//{
//    int[] numbers = new int[] { 10, 20, 30, 40, 1, 2, 3, 8 };
//    var subset = from i in numbers where i < 10 select i;
//    foreach (var i in subset)
//    {
//        console.writeline(i);
//    }
//    console.writeline(subset.gettype().name);
//    console.writeline(subset.gettype().namespace);
//}

//static void conditionalrefexample()
//{
//    var smallarray = new int[] { 1, 2, 3, 4, 5 };
//    var largearray = new int[] { 10, 20, 30, 40, 50 };
//    int idx = 7;
//    ref int refvalue = ref ((idx < 5) ? ref smallarray[idx] : ref largearray[idx - 5]);
//    refvalue = 0;
//    idx = 2;
//    ((idx < 5) ? ref smallarray[idx] : ref largearray[idx]) = 100;
//    console.writeline(string.join(" ", smallarray)); // 1 2 100 4 5
//    console.writeline(string.join(" ", largearray)); // 10 20 0 40 50
//}

//static void switchonenum()
//{
//    console.write("enter your faorite day of week: ");
//    dayofweek favday;
//    try
//    {
//        favday = (dayofweek)enum.parse(typeof(dayofweek), console.readline());
//    }
//    catch (exception)
//    {
//    console.writeline("bad input!");
//    return;
//}
//switch (favday)
//{
//    case dayofweek.sunday:
//    case dayofweek.saturday:
//        console.writeline("relax~");
//        break;
//    case dayofweek.monday:
//        console.writeline("is there anything worse?");
//        goto case dayofweek.tuesday;
//    case dayofweek.tuesday:
//    case dayofweek.wednesday:
//        console.writeline("at least it is not monday");
//        break;
//    case dayofweek.thursday:
//        console.writeline("hangout with friends");
//        break;
//    case dayofweek.friday:
//        console.writeline("party all night!");
//        break;
//}
//}

//static void partternmatchingswitch()
//{
//    console.writeline("1 [c#], 2 [vb]");
//    console.write("pick your language preference: ");
//    object langchoice = console.readline();
//    var choice = int.tryparse(langchoice.tostring(), out int c) ? c : langchoice;
//    switch (choice)
//    {
//        case int i when i == 2:
//        case string s when s.equals("vb", stringcomparison.ordinalignorecase):
//            console.writeline("vb: oop, multithreading, and more!");
//            break;
//        case int i when i == 1:
//        case string s when s.equals("c#", stringcomparison.ordinalignorecase):
//            console.writeline("c#: good choice, c# is a fine language");
//            break;
//        default:
//            console.writeline("well...good luck with that!");
//            break;
//    }
//}

//static string fromrainbow(string colorband)
//{
//    return colorband switch
//    {
//        "red" => "#ff0000",
//        "orange" => "#ff7f00",
//        "yellow" => "#ffff00",
//        "green" => "#00ff00",
//        "blue" => "#0000ff",
//        "indigo" => "#4b0082",
//        "violet" => "#9400d3",
//        _ => "#ffffff",
//    };
//}

//static string rockpaperscissors(string first, string second)
//{
//    return (first, second) switch
//    {
//        ("rock", "paper") => "paper wins.",
//        ("rock", "scissors") => "rock wins.",
//        ("paper", "rock") => "paper wins.",
//        ("paper", "scissors") => "scissors wins.",
//        ("scissors", "rock") => "rock wins.",
//        ("scissors", "paper") => "scissors wins.",
//        (_, _) => "tie.",
//    };
//}

//static void rectarray()
//{
//    int[,] mymatrix;
//    mymatrix = new int[3, 4];
//    for (int i = 0; i < 3; i++)
//        for (int j = 0; j < 4; j++)
//            mymatrix[i, j] = i * j;
//    for (int i = 0; i < 3; i++)
//    {
//        for (int j = 0; j < 4; j++)
//            console.write(mymatrix[i, j] + "\t");
//        console.writeline();
//    }
//}

//static void jaggedarray()
//{
//    int[][] myjaggedarray = new int[5][];
//    for (int i = 0; i < myjaggedarray.length; i++)
//        myjaggedarray[i] = new int[i + 7];
//    for (int i = 0; i < myjaggedarray.length; i++)
//    {
//        for (int j = 0; j < myjaggedarray[i].length; j++)
//            console.write(myjaggedarray[i][j] + " ");
//        console.writeline();
//    }
//}