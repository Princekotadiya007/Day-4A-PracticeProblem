using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();

            // Add some items to the dictionary
            dict.Add(1, "Alice");
            dict.Add(2, "Bob");
            dict.Add(3, "Charlie");

            // Read an item from the dictionary
            Console.WriteLine($"Item with key 2: {dict[2]}");

            // Update an item in the dictionary
            dict[2] = "Barbara";
            Console.WriteLine($"Item with key 2 after updating: {dict[2]}");

            // Delete an item from the dictionary
            dict.Remove(3);
            Console.WriteLine($"Item with key 3 after deleting: {dict.ContainsKey(3)}");

            // Iterate over the dictionary
            Console.WriteLine("All items in the dictionary:");
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
