namespace Single_Responsibility.Interfaces;

public interface ICartStorage
{
    void Save(ShoppingCart cart);

    ShoppingCart Load();
}