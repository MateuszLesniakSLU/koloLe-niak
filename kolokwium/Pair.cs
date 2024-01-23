namespace kolokwium
{
    public class Pair<T, S>(T first, S second) : IComparable<Pair<T, S>>
        where T : IComparable<T>
        where S : IComparable<S>
    {
        public T First { get; private set; } = first;
        public S Second { get; private set; } = second;

        public int CompareTo(Pair<T, S> other)
        {
            int firstComparison = First.CompareTo(other.First);
            if (firstComparison != 0)
                return firstComparison;

            return Second.CompareTo(other.Second);
        }

        public override string ToString()
        {
            return $"({First}, {Second})";
        }
    }
}
