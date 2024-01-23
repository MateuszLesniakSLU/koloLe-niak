namespace kolokwium
{
    public class Storage<T>
    {
        private List<T> items = new List<T>();

        public delegate void ItemAddedEventHandler(T item);
        public event ItemAddedEventHandler ItemAdded;

        public void Add(T newItem)
        {
            items.Add(newItem);
            ItemAdded?.Invoke(newItem);
        }

        public void Delete(T item)
        {
            items.Remove(item);
        }

        public void Sort(Comparison<T> comparison)
        {
            items.Sort(comparison);
        }

        public List<T> Filter(Predicate<T> predicate)
        {
            return items.FindAll(predicate);
        }

        public List<T> Items
        {
            get { return new List<T>(items); }
        }
    }
}
