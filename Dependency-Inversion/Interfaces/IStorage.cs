namespace Dependency_Inversion.Interfaces;

public interface IStorage
{
    public void Save(ShoppingCart cart);
    public ShoppingCart Load();
}