// See https://aka.ms/new-console-template for more information

using Single_Responsibility;
using Single_Responsibility.Interfaces;

var cart = new ShoppingCart();
cart.Add(new ShoppingCartItem()
{
    Price = 1200,
    ProductId = 1,
    Quantity = 1,

    Title = "iPhone 12"
});
cart.Add(new ShoppingCartItem()
{
    Price = 1400,
    ProductId = 1,
    Quantity = 2,
    Title = "iPhone 14"
});

// Initialize the PrintCartConsole object
ICartPrinter cartPrinter = new PrintCartConsole();

// Initialize the CartStorageFile object
ICartStorage cartStorageFile = new CartStorageFile("cart.json");

cartPrinter.Print(cart);

Console.WriteLine("Writing to file...");
cartStorageFile.Save(cart);

cart.Clear();
Console.WriteLine($"Now is empty == {!cart.Items.Any()}");
cartPrinter.Print(cart);

var loadedCartFile = cartStorageFile.Load();

Console.WriteLine("Loaded from file");

cartPrinter.Print(loadedCartFile);