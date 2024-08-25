using System.Text.Json;
using Dependency_Inversion.Interfaces;

namespace Dependency_Inversion.Storage
{
    public class FileStorage : IStorage
    {
        private readonly string _fileName;

        public FileStorage(string fileName)
        {
            _fileName = fileName;
        }

        public ShoppingCart? Load()
        {
            using var reader = new StreamReader(new FileStream(_fileName, FileMode.Open));
            var jsonString = reader.ReadToEnd();
            reader.Close();

            var loadItems = JsonSerializer.Deserialize<List<ShoppingCartItem>>(jsonString);
            if (loadItems != null)
            {
                var cart = new ShoppingCart();
                foreach (var item in loadItems)
                {
                    cart.Add(item);
                }

                return cart;
            }

            return null;
        }

        public void Save(ShoppingCart cart)
        {
            string jsonString = JsonSerializer.Serialize(cart.Items);

            using var writer = new StreamWriter(new FileStream(_fileName, FileMode.Create));
            writer.Write(jsonString);
            writer.Flush();
            writer.Close();
        }
    }
}