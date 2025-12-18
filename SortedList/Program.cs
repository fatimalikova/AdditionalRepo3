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
            //int integer = 7;
            //Console.WriteLine(stack.TryPeek(out integer));
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

            #region Queue(Non-Generic)
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine(queue.Contains(1));
            //Console.WriteLine("Queue contents:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Dequeued item: {queue.Dequeue()}");
            //Console.WriteLine("Queue contents after dequeue:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Queue(Generic)
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //Console.WriteLine(queue.Contains(1));
            //Console.WriteLine("Queue contents:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine($"Dequeued item: {queue.Dequeue()}");
            //Console.WriteLine("Queue contents after dequeue:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Hashtable

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("A", "Apple");
            //hashtable.Add("B", "Banana");
            //hashtable.Add("C", "Cherry");
            //hashtable["D"] = "Date";
            //Console.WriteLine(hashtable.ContainsKey("B"));
            //Console.WriteLine("Hashtable contents:");
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}
            //hashtable.Remove("C");
            //Console.WriteLine("Hashtable contents after removing key 'C':");
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}
            #endregion

            #region Hashset
            //HashSet<int> hashSet = new HashSet<int>();
            //hashSet.Add(1);
            //hashSet.Add(2);
            //hashSet.Add(3);
            //hashSet.Add(2); // Duplicate, will not be added
            //Console.WriteLine(hashSet.Contains(2));
            //Console.WriteLine("HashSet contents:");
            //foreach (var item in hashSet)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Dictionary(Generic)
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(1, "One");
            //dictionary.Add(2, "Two");
            //dictionary[3] = "Three";
            //Console.WriteLine(dictionary.Count.ToString());
            //Console.WriteLine(dictionary.ContainsKey(2));
            //Console.WriteLine("Dictionary contents:");
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}

            Dictionary<int, string> anotherDict = new Dictionary<int, string>()
            {
                {4, "Four" },
                {5, "Five" },
                {6, "Six" }
            };
            //Merging two dictionaries
            foreach (var item in anotherDict)
            {
                anotherDict[item.Key] = item.Value; // This will add or update the value
            }
            Console.WriteLine("Merged Dictionary contents:");
            foreach (var item in anotherDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            #endregion
        }
    }
}
