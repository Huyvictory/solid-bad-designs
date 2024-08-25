namespace Interface_Segregation.Interfaces;

public interface ICart
{
    void AddProduct(int productId, int quantity);
    void RemoveProduct(int productId, int quantity);
    IDictionary<int, int> GetCartItems();
}