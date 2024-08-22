using Open_Closed;
using Open_Closed.GreetingCountries;

Console.WriteLine("Choose a language: ");
Console.WriteLine("1. English");
Console.WriteLine("2. Norwegian");
Console.WriteLine("3. Swedish");
Console.WriteLine("4. Vietnamese");
Console.WriteLine("5. Spanish");

var l = Console.ReadLine();

IGreeting? greeting = l switch
{
    "1" => new GreetingEnglish(),
    "2" => new GreetingNorwegian(),
    "3" => new GreetingSweden(),
    "4" => new GreetingVietnam(),
    "5" => new GreetingSpain(),
    _ => null
};

greeting?.SayHi();