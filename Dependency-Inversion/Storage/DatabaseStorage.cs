using Dependency_Inversion.Interfaces;

namespace Dependency_Inversion.Storage;

public class DatabaseStorage : IStorage
{
    public void Save(ShoppingCart cart)
    {
        Console.WriteLine("Save cart contents into database as a new implementation of interface IStorage");
    }

    public ShoppingCart Load()
    {
        Console.WriteLine("Load cart contents from database as a new implementation of interface IStorage");
        return new ShoppingCart();
    }
}