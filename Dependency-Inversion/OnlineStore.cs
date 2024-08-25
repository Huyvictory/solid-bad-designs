using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependency_Inversion.Interfaces;
using Dependency_Inversion.Printer;
using Dependency_Inversion.Storage;

namespace Dependency_Inversion
{
    public class OnlineStore
    {
        private readonly IPrinter _printer;
        private readonly IStorage _storage;

        public ShoppingCart Cart { get; private set; }

        public OnlineStore(IPrinter printer, IStorage storage)
        {
            Cart = new ShoppingCart();

            _printer = printer;
            _storage = storage;
        }

        public void Save()
        {
            _storage.Save(Cart);
        }

        public void Load()
        {
            var cart = _storage.Load();
            if (cart != null)
            {
                Cart = cart;
            }
            else
            {
                throw new Exception("Error loading cart");
            }
        }

        public void Print()
        {
            _printer.Print(Cart);
        }
    }
}