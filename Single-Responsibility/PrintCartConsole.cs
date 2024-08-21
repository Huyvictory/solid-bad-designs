using Single_Responsibility.Interfaces;

namespace Single_Responsibility;

public class PrintCartConsole : ICartPrinter
{
    public void Print(ShoppingCart cart)
    {
        Console.WriteLine();
        Console.WriteLine("SHOPPING CART");
        Console.WriteLine("~~~~~~~~~~~~~");

        var shoppingCartItem = cart.Items;

        foreach (var item in shoppingCartItem)
        {
            Console.WriteLine($"{item.Title} - {item.Price:C} x {item.Quantity} = {item.Quantity * item.Price:C}");
        }

        // print total
        Console.WriteLine($"Total: {cart.GetTotal():C}");
    }
}