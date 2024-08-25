using Interface_Segregation;
using Interface_Segregation.Interfaces;

IOnlineStore onlineStore = new OnlineStore();
ICart cart = new Cart();
var checkoutInfo = new CheckoutInfo();

cart.AddProduct(1, 1);
cart.AddProduct(2, 10);
cart.AddProduct(3, 100);

cart.RemoveProduct(1, 1);
cart.RemoveProduct(2, 5);

var order = onlineStore.Checkout(cart, checkoutInfo);
Console.WriteLine($"Order created, Id = {order.Id}");