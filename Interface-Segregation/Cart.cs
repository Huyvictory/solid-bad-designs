using Interface_Segregation.Interfaces;

namespace Interface_Segregation;

public class Cart : ICart
{
    private readonly Dictionary<int, int> cart = new Dictionary<int, int>();

    public void AddProduct(int productId, int quantity)
    {
        if (cart.ContainsKey(productId))
        {
            cart[productId] = cart[productId] + quantity;
        }
        else
        {
            cart.Add(productId, quantity);
        }
    }

    public void RemoveProduct(int productId, int quantity)
    {
        if (cart.TryGetValue(productId, out int value))
        {
            int newQuantity = value - quantity;
            if (newQuantity > 0)
            {
                cart[productId] = newQuantity;
            }
            else
            {
                cart.Remove(productId);
            }
        }
    }

    public IDictionary<int, int> GetCartItems()
    {
        return cart;
    }
}