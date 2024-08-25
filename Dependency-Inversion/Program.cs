using Dependency_Inversion;
using Dependency_Inversion.Interfaces;
using Dependency_Inversion.Printer;
using Dependency_Inversion.Storage;

IPrinter printer = new ConsolePrinter();
IStorage fileStorage = new FileStorage("cart.json");
var store = new OnlineStore(printer, fileStorage);

store.Cart.Add(new ShoppingCartItem()
{
    Price = 1200,
    ProductId = 1,
    Quantity = 1,
    Title = "iPhone 12"
});
store.Cart.Add(new ShoppingCartItem()
{
    Price = 1400,
    ProductId = 1,
    Quantity = 2,
    Title = "iPhone 14"
});

store.Print();
store.Save();

store.Cart.Clear();
store.Print();

store.Load();
store.Print();

// For new implementations of interfaces
IPrinter printerGui = new GUIPrinter();
IStorage databaseStorage = new DatabaseStorage();

printerGui.Print(store.Cart);

databaseStorage.Save(store.Cart);
databaseStorage.Load();