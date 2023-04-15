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
            //Sum sum = new Sum();
            //sum.DoSum(10, 20);

            // Create a new ArrayList
            ArrayList list = new ArrayList();

            // Add some items to the list
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Cherry");
            list.Add("Durian");

            // Print the items in the list
            Console.WriteLine("Items in the list:");
            PrintList(list);

            // Update an item in the list
            list[2] = "Grape";

            // Print the items in the list again
            Console.WriteLine("\nItems in the list after updating an item:");
            PrintList(list);

            // Remove an item from the list
            list.RemoveAt(1);

            // Print the items in the list again
            Console.WriteLine("\nItems in the list after removing an item:");
            PrintList(list);

            // Insert an item into the list
            list.Insert(0, "Fig");

            // Print the items in the list again
            Console.WriteLine("\nItems in the list after inserting an item:");
            PrintList(list);

            // Clear all items from the list
            list.Clear();

            // Print the items in the list again
            Console.WriteLine("\nItems in the list after clearing all items:");
            PrintList(list);

            Console.ReadKey();
        }

        // Helper method to print the items in the list
        static void PrintList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
