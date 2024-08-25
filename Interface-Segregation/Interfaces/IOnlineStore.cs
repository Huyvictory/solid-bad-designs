namespace Interface_Segregation.Interfaces
{
    public interface IOnlineStore
    {
        Order Checkout(ICart cart, CheckoutInfo checkoutInfo);
    }
}