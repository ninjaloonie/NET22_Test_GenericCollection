namespace FinalExam
{
    public class TestCollection<T> where T : struct
    {
        private readonly List<T> _items;

        public TestCollection()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T Get(int index)
        {
            return _items[index];
        }

        public List<T> ListDescending()
        {
            var items = new List<T>(_items);
            items.Sort();
            items.Reverse();
            return items;
        }
    }
}