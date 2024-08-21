namespace Single_Responsibility
{
    public class ShoppingCart
    {
        private List<ShoppingCartItem> items { get; set; } = new List<ShoppingCartItem>();

        public IEnumerable<ShoppingCartItem> Items
        {
            get { return items; }
            set { items = (List<ShoppingCartItem>)value; }
        }

        public void Add(ShoppingCartItem item)
        {
            items.Add(item);
        }

        public void Remove(ShoppingCartItem item)
        {
            items.Remove(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public double GetTotal()
        {
            return items.Sum(i => i.Quantity * i.Price);
        }
    }
}