using System.Text.Json;
using Single_Responsibility.Interfaces;

namespace Single_Responsibility;

public class CartStorageFile : ICartStorage
{
    private string FileName { get; set; }

    public CartStorageFile(string fileName)
    {
        FileName = fileName;
    }

    public void Save(ShoppingCart cart)
    {
        var jsonString = JsonSerializer.Serialize(cart.Items);

        using var writer = new StreamWriter(new FileStream(FileName, FileMode.Create));
        writer.Write(jsonString);
        writer.Flush();
        writer.Close();
    }

    public ShoppingCart Load()
    {
        List<ShoppingCartItem> items = new List<ShoppingCartItem>();
        using var reader = new StreamReader(new FileStream(FileName, FileMode.Open));
        var jsonString = reader.ReadToEnd();
        reader.Close();

        items.Clear();
        var loadItems = JsonSerializer.Deserialize<List<ShoppingCartItem>>(jsonString);
        if (loadItems != null)
        {
            items.AddRange(loadItems);
        }

        var cart = new ShoppingCart
        {
            Items = items
        };

        return cart;
    }
}