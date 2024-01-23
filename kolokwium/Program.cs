namespace kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage<string> storage = new Storage<string>();
            storage.Add("Jabłko");
            storage.Add("Pomarańcza");
            storage.Add("Banana");
            storage.Add("Gruszka");
            storage.Add("Wiśnia");

            Console.WriteLine("Sortowanie alfabetycznie:");
            storage.Sort((x, y) => string.Compare(x, y));
            PrintStorage(storage);

            Console.WriteLine("\nSortowanie według długości:");
            storage.Sort((x, y) => x.Length.CompareTo(y.Length));
            PrintStorage(storage);

            Console.WriteLine("\nFiltrowanie: zawierające literę 'a':");
            var filtered = storage.Filter(item => item.Contains("a"));
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintStorage(Storage<string> storage)
        {
            foreach (var item in storage.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
