using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a Stack
        Stack<string> Myfood = new Stack<string>();

        // Add 5 items to the Stack
        Myfood.Push("tacos");
        Myfood.Push("pizza");
        Myfood.Push("pasta");
        Myfood.Push("pho");
        Myfood.Push("bbq");

        Console.WriteLine("USING STACK");

        // Check if the stack contains a specific item
        Console.WriteLine("what item are you looking for?");


        string itemToCheck = Console.ReadLine();
        bool containsItem = Myfood.Contains(itemToCheck);
        Console.WriteLine($"Does the stack contain '{itemToCheck}'? {containsItem}");

        // Remove the last item
        string removedItem = Myfood.Pop();
        Console.WriteLine($"this Meal was removed: {removedItem}");

        // Count the items in the stack and display the count
        int foodCount = Myfood.Count;
        Console.WriteLine($"Number of foods in the stack: {foodCount}");

        // Print all the items in the stack
        Console.WriteLine("All foods in the stack:");
        foreach (string item in Myfood)
        {
            Console.WriteLine(item);
        }




        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        Console.WriteLine("USING LINKED LIST");
        // Create a LinkedList
        LinkedList<string> top5Meals = new LinkedList<string>();

        // Add 5 items to the linked list
        top5Meals.AddLast("pho");
        top5Meals.AddLast("tacos");
        top5Meals.AddLast("ramen");
        top5Meals.AddLast("pasta");
        top5Meals.AddLast("soup");

        // Retrieve and display the first node
        LinkedListNode<string> firstNode = top5Meals.First;
        Console.WriteLine("First Meal: " + firstNode.Value);

        // Retrieve and display the last node
        LinkedListNode<string> lastNode = top5Meals.Last;
        Console.WriteLine("Last Meal: " + lastNode.Value);

        // Add a 6th item to the middle of the list
        LinkedListNode<string> middleNode = top5Meals.Find("ramen");
        if (middleNode != null)
        {
            top5Meals.AddAfter(middleNode, "spring rolls");
        }

        // Remove a node from the list (it can be the first, last, or a node with a specific value)
        top5Meals.RemoveLast(); // Removing the first node

        // Count the items in the linked list and display the count
        int itemCount = top5Meals.Count;
        Console.WriteLine("Number of meals in the linked list: " + itemCount);

        // Print all the items in the linked list
        Console.WriteLine("Items in the linked list:");
        foreach (string item in top5Meals)
        {
            Console.WriteLine(item);
        }
    }
}

