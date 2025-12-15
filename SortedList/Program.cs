using System.Collections;
using System.Collections.Generic; 

namespace SortedListApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SortedList(Generic)
            //SortedList<int, string> sortedList = new SortedList<int, string>();
            //sortedList.Add(3, "Three");
            //sortedList.Add(1, "One");
            //sortedList.Add(2, "Two");
            //sortedList.Add(5, "Five");
            //sortedList.Add(4, "Four");
            //sortedList.Remove(2);
            //Console.WriteLine(sortedList.TryAdd(4, "Four Duplicate"));

            //Console.WriteLine("====================================");
            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}

            //Console.WriteLine(sortedList.Remove(3)); 
            #endregion

            #region SortedList(Non-Generic)

            //SortedList sortedList = new SortedList();
            //sortedList.Add(3, "Three");
            //sortedList.Add(1, "One");
            //sortedList.Add(2, "Two");
            //sortedList.Add(5, "Five");
            //sortedList.Add(4, "Four");
            //sortedList.Remove(2);
            //sortedList.Capacity = 10;
            //sortedList.TrimToSize();
            //Console.WriteLine(sortedList.ContainsKey(7));
            //Console.WriteLine("====================================");
            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}
            #endregion

            #region Stack(Generic) LIFO
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine("Stack contents:");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Popped item: {stack.Pop()}");
            //Console.WriteLine("Stack contents after pop:");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack(Non-Generic) LIFO
            //Stack stack = new Stack(8);
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine("Stack contents:");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Popped item: {stack.Pop()}");
            //Console.WriteLine("Stack contents after pop:");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
