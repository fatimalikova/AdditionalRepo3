namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            sortedList.Add(5, "Five");
            sortedList.Add(4, "Four");
            sortedList.Remove(2);
            Console.WriteLine(sortedList.TryAdd(4, "Four Duplicate"));

            Console.WriteLine("====================================");
            foreach (var item in sortedList)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            //Console.WriteLine(sortedList.Remove(3));
        }
    }
}
