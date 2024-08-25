using Dependency_Inversion.Interfaces;

namespace Dependency_Inversion.Printer;

public class GUIPrinter : IPrinter
{
    public void Print(ShoppingCart cart)
    {
        Console.WriteLine("Print cart contents into GUI as a new implementation of interface IPrinter");
    }
}